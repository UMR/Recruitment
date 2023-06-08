namespace Recruitment.Application.Features.Agencies;

internal class AgencyService : IAgencyService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IAgencyRepository _agencyRepository;

    public AgencyService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IAgencyRepository agencyRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _agencyRepository = agencyRepository;
    }

    public async Task<List<AgencyListDto>> GetAgenciesAsync()
    {
        var agenciesFromRepo = await _agencyRepository.GetAgenciesAsync();
        var agenciesToReturn = _mapper.Map<List<AgencyListDto>>(agenciesFromRepo);
        return agenciesToReturn;
    }

    public async Task<AgencyListDto> GetAgencyByIdAsync(int id)
    {
        var agencyFromRepo = await _agencyRepository.GetAgencyByIdAsync(id);
        var agencyToReturn = _mapper.Map<AgencyListDto>(agencyFromRepo);
        return agencyToReturn;
    }

    public async Task<bool> IsExistAgencyNameAsync(string agencyName) 
    {
        return await _agencyRepository.IsExistAgencyNameAsync(agencyName);
    }

    public async Task<BaseCommandResponse> CreateAgencyAsync(CreateAgencyDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateAgencyDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new Agency
        {
            AgencyName = request.AgencyName,
            AgencyAddress = request.AgencyAddress,
            URLPrefix = request.URLPrefix,
            AgencyEmail = request.AgencyEmail,
            AgencyPhone = request.AgencyPhone,
            AgencyContactPerson = request.AgencyContactPerson,
            AgencyContactPersonPhone = request.AgencyContactPersonPhone,
            IsActive = request.IsActive,
            AgencyLoginId = request.AgencyLoginId,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _agencyRepository.CreateAgencyAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAgencyAsync(int id, UpdateAgencyDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateAgencyDtoValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.AgencyId)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _agencyRepository.GetAgencyByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        entity.AgencyId = request.AgencyId;
        entity.AgencyName = request.AgencyName;
        entity.AgencyAddress = request.AgencyAddress;
        entity.URLPrefix = request.URLPrefix;
        entity.AgencyEmail = request.AgencyEmail;
        entity.AgencyPhone = request.AgencyPhone;
        entity.AgencyContactPerson = request.AgencyContactPerson;
        entity.AgencyContactPersonPhone = request.AgencyContactPersonPhone;
        entity.IsActive = request.IsActive;
        entity.AgencyLoginId = request.AgencyLoginId;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _agencyRepository.UpdateAgencyAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }
    public async Task<BaseCommandResponse> UpdateAgencyStatusAsync(int id, UpdateAgencyStatusDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateAgencyStatusDtoValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.AgencyId)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _agencyRepository.GetAgencyByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        entity.AgencyId = request.AgencyId;
        entity.IsActive = request.IsActive;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _agencyRepository.UpdateAgencyAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAgencyAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _agencyRepository.GetAgencyByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        await _agencyRepository.DeleteAgencyAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
