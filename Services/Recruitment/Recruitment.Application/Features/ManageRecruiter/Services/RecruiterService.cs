namespace Recruitment.Application.Features.ManageRecruiter;

public class RecruiterService : IRecruiterService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IEmailTypeRepository _emailTypeRepository;

    public RecruiterService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IEmailTypeRepository emailTypeRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _emailTypeRepository = emailTypeRepository;
    }

    async Task<List<RecruiterListDto>> IRecruiterService.GetAllRecruitersAsync()
    {
        var emailTypesFromRepo = await _emailTypeRepository.GetEmailTypesAsync();
        var emailTypesToReturn = _mapper.Map<List<RecruiterListDto>>(emailTypesFromRepo);
        return emailTypesToReturn;
    }

    public async Task<RecruiterListDto> GetRecruiterByIdAsync(int id)
    {
        var emailTypeFromRepo = await _emailTypeRepository.GetEmailTypeByIdAsync(id);
        var emailTypeToReturn = _mapper.Map<RecruiterListDto>(emailTypeFromRepo);
        return emailTypeToReturn;
    }

    public async Task<BaseCommandResponse> CreateRecruiterAsync(CreateRecruiterDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateRecruiterDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new EmailType
        {
            Type = request.Type,
            IsPersonal = request.IsPersonal,
            IsOfficial = request.IsOfficial,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _emailTypeRepository.CreateEmailTypeAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateRecruiterAsync(int id, UpdateRecruiterDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateRecruiterDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.Id)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _emailTypeRepository.GetEmailTypeByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        entity.Id = request.Id;
        entity.Type = request.Type;
        entity.IsOfficial = request.IsOfficial;
        entity.IsPersonal = request.IsPersonal;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _emailTypeRepository.UpdateEmailTypeAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteRecruiterAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _emailTypeRepository.GetEmailTypeByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        await _emailTypeRepository.DeleteEmailTypeAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
