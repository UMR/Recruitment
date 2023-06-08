namespace Recruitment.Application.Features.EmailTypes;

internal class EmailTypeService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IEmailTypeRepository _emailTypeRepository;

    public EmailTypeService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IEmailTypeRepository emailTypeRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _emailTypeRepository = emailTypeRepository;
    }

    public async Task<List<EmailTypeListDto>> GetEmailTypesAsync()
    {
        var emailTypesFromRepo = await _emailTypeRepository.GetEmailTypesAsync();
        var emailTypesToReturn = _mapper.Map<List<EmailTypeListDto>>(emailTypesFromRepo);
        return emailTypesToReturn;
    }

    public async Task<EmailTypeListDto> GetEmailTypeByIdAsync(int id)
    {
        var emailTypeFromRepo = await _emailTypeRepository.GetEmailTypeByIdAsync(id);
        var emailTypeToReturn = _mapper.Map<EmailTypeListDto>(emailTypeFromRepo);
        return emailTypeToReturn;
    }

    public async Task<BaseCommandResponse> CreateAgencyAsync(CreateAgencyDto request)
    {
        var response = new BaseCommandResponse();
        //var validator = new CreateAgencyDtoValidator(this);
        //var validationResult = await validator.ValidateAsync(request);

        //if (validationResult.IsValid == false)
        //{
        //    response.Success = false;
        //    response.Message = "Creating Failed";
        //    response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
        //    return response;
        //}

        //var entity = new Agency
        //{
        //    AgencyName = request.AgencyName,
        //    AgencyAddress = request.AgencyAddress,
        //    URLPrefix = request.URLPrefix,
        //    AgencyEmail = request.AgencyEmail,
        //    AgencyPhone = request.AgencyPhone,
        //    AgencyContactPerson = request.AgencyContactPerson,
        //    AgencyContactPersonPhone = request.AgencyContactPersonPhone,
        //    IsActive = request.IsActive,
        //    AgencyLoginId = request.AgencyLoginId,
        //    CreatedBy = _currentUserService.UserId,
        //    CreatedDate = _dateTime.Now
        //};
        //await _agencyRepository.CreateAgencyAsync(entity);

        //response.Success = true;
        //response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAgencyAsync(int id, UpdateAgencyDto request)
    {
        var response = new BaseCommandResponse();
        //var validator = new UpdateAgencyDtoValidator(this);
        //var validationResult = await validator.ValidateAsync(request);

        //if (validationResult.IsValid == false)
        //{
        //    response.Success = false;
        //    response.Message = "Updating Failed";
        //    response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
        //    return response;
        //}

        //if (id != request.AgencyId)
        //{
        //    throw new BadRequestException("Id does not match");
        //}

        //var entity = await _agencyRepository.GetAgencyByIdAsync(id);

        //if (entity is null)
        //{
        //    throw new NotFoundException(nameof(User), id.ToString());
        //}

        //entity.AgencyId = request.AgencyId;
        //entity.AgencyName = request.AgencyName;
        //entity.AgencyAddress = request.AgencyAddress;
        //entity.URLPrefix = request.URLPrefix;
        //entity.AgencyEmail = request.AgencyEmail;
        //entity.AgencyPhone = request.AgencyPhone;
        //entity.AgencyContactPerson = request.AgencyContactPerson;
        //entity.AgencyContactPersonPhone = request.AgencyContactPersonPhone;
        //entity.IsActive = request.IsActive;
        //entity.AgencyLoginId = request.AgencyLoginId;
        //entity.UpdatedBy = _currentUserService.UserId;
        //entity.UpdatedDate = _dateTime.Now;
        //await _agencyRepository.UpdateAgencyAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAgencyAsync(int id)
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
