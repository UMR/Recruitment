namespace Recruitment.Application.Features.EmailTypes;

public class EmailTypeService : IEmailTypeService
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

    public async Task<List<EmailTypeListDto>> GetAllAsync()
    {
        var entitiesFromRepo = await _emailTypeRepository.GetAllAsync();
        var entitiesToReturn = _mapper.Map<List<EmailTypeListDto>>(entitiesFromRepo);
        return entitiesToReturn;
    }

    public async Task<EmailTypeListDto> GetByIdAsync(int id)
    {
        var entityFromRepo = await _emailTypeRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<EmailTypeListDto>(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistAsync(string emailType, int? id = null)
    {
        return await _emailTypeRepository.IsExistAsync(emailType, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreateEmailTypeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateEmailTypeDtoValidator(this);
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
        await _emailTypeRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(int id, UpdateEmailTypeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateEmailTypeDtoValidator(this);
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

        var entity = await _emailTypeRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(EmailType), id.ToString());
        }

        entity.Id = request.Id;
        entity.Type = request.Type;
        entity.IsOfficial = request.IsOfficial;
        entity.IsPersonal = request.IsPersonal;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _emailTypeRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _emailTypeRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(EmailType), id.ToString());
        }

        var result = await _emailTypeRepository.DeleteAsync(id);

        if (!string.IsNullOrEmpty(result)) 
        {
            response.Success = false;
            response.Message = result;
            return response;
        }

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
