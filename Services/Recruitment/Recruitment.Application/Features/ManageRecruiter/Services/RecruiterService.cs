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
    async Task<List<RecruiterListDto>> IRecruiterService.GetAllRecruitersByAsync(SearchRecruiterParamDto searchRecruiterParamDto)
    {
        var recruiterFromRepo = await _recruiterRepository.GetAllRecruitersByAsync(searchRecruiterParamDto);
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
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            AgencyId = request.AgencyId,
            ApplicantTypeId = request.ApplicantTypeId,
            IsActive = request.IsActive,
            LoginId = request.LoginId,
            Password = request.Password,
            Telephone = request.Telephone,
            TimeOut = request.TimeOut,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = DateTime.Now
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

        if (id != request.UserId)
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
        entity.FirstName = request.FirstName;
        entity.LastName = request.LastName;
        entity.Email = request.Email;
        entity.IsActive = request.IsActive;
        entity.Telephone = request.Telephone;
        entity.AgencyId = request.AgencyId;
        entity.ApplicantTypeId = request.ApplicantTypeId;
        entity.TimeOut = request.TimeOut;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = DateTime.Now;
        await _recruiterRepository.UpdateRecruiterAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteRecruiterAsync(int deleteUserId, int updatedUserId)
    {
        var response = new BaseCommandResponse();
        var entity = await _recruiterRepository.GetRecruiterByIdAsync(deleteUserId);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), deleteUserId.ToString());
        }

        await _recruiterRepository.DeleteRecruiterAsync(deleteUserId, updatedUserId);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
