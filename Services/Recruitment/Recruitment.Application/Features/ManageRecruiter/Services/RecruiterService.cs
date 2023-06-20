namespace Recruitment.Application.Features.ManageRecruiter;

public class RecruiterService : IRecruiterService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IRecruiterRepository _recruiterRepository;

    public RecruiterService(IMapper mapper, ICurrentUserService currentUserService, IRecruiterRepository recruiterRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _recruiterRepository = recruiterRepository;
    }

    async Task<List<RecruiterListDto>> IRecruiterService.GetAllRecruitersAsync()
    {
        var recruiterFromRepo = await _recruiterRepository.GetAllRecruitersAsync();
        var recruiterToReturn = _mapper.Map<List<RecruiterListDto>>(recruiterFromRepo);
        return recruiterToReturn;
    }

    public async Task<RecruiterListDto> GetRecruiterByIdAsync(int id)
    {
        var recruiterFromRepo = await _recruiterRepository.GetRecruiterByIdAsync(id);
        var recruiterToReturn = _mapper.Map<RecruiterListDto>(recruiterFromRepo);
        return recruiterToReturn;
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

        var entity = new User
        {
            //Type = request.Type,
            //IsPersonal = request.IsPersonal,
            //IsOfficial = request.IsOfficial,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _recruiterRepository.CreateRecruiterAsync(entity);

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

        var entity = await _recruiterRepository.GetRecruiterByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        //entity.Id = request.Id;
        //entity.Type = request.Type;
        //entity.IsOfficial = request.IsOfficial;
        //entity.IsPersonal = request.IsPersonal;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _recruiterRepository.UpdateRecruiterAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteRecruiterAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _recruiterRepository.GetRecruiterByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        await _recruiterRepository.DeleteRecruiterAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
