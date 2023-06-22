namespace Recruitment.Application.Features.ApplicantType;

public class ApplicantTypeService : IApplicantTypeService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IApplicantTypeRepository _applicantTypeRepository;

    public ApplicantTypeService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IApplicantTypeRepository applicantTypeRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _applicantTypeRepository = applicantTypeRepository;
    }

    public async Task<List<ApplicantTypeEntity>> GetAllAsync()
    {
        var entitiesFromRepo = await _applicantTypeRepository.GetAllAsync();
        var entitiesToReturn = _mapper.Map<List<ApplicantTypeEntity>>(entitiesFromRepo);
        return entitiesToReturn;
    }

    public async Task<ApplicantTypeListDto> GetByIdAsync(int id)
    {
        var entityFromRepo = await _applicantTypeRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<ApplicantTypeListDto>(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistAsync(string ApplicantType, int? id = null)
    {
        return await _applicantTypeRepository.IsExistAsync(ApplicantType, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreateApplicantTypeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateApplicantTypeDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new ApplicantTypeEntity
        {
            Name = request.Name,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };

        await _applicantTypeRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(int id, UpdateApplicantTypeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateApplicantTypeDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.ApplicantTypeId)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _applicantTypeRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        entity.ApplicantTypeId = request.ApplicantTypeId;
        entity.Name = request.Name;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _applicantTypeRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _applicantTypeRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        await _applicantTypeRepository.DeleteAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
