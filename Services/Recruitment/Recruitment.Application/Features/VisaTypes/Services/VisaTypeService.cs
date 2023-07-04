namespace Recruitment.Application.Features.VisaTypes;

public class VisaTypeService:IVisaTypeService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IVisaTypeRepository _visaTypeRepository;

    public VisaTypeService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IVisaTypeRepository visaTypeRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _visaTypeRepository = visaTypeRepository;
    }

    public async Task<List<VisaTypeListDto>> GetAllAsync()
    {
        var entitiesFromRepo = await _visaTypeRepository.GetAllAsync();
        var entitiesToReturn = _mapper.Map<List<VisaTypeListDto>>(entitiesFromRepo);
        return entitiesToReturn;
    }

    public async Task<VisaTypeListDto> GetByIdAsync(int id)
    {
        var entityFromRepo = await _visaTypeRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<VisaTypeListDto>(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistVisaTypeAsync(string visatType, int? id = null)
    {
        return await _visaTypeRepository.IsExistVisaTypeAsync(visatType, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreateVisaTypeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateVisaTypeDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new VisaTypeEntity
        {
            VisaType = request.VisaType,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _visaTypeRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(int id, UpdateVisaTypeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateVisaTypeDtoValidator(this);
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

        var entity = await _visaTypeRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(VisaTypeEntity), id.ToString());
        }

        entity.Id = request.Id;
        entity.VisaType = request.VisaType;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _visaTypeRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _visaTypeRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(VisaTypeEntity), id.ToString());
        }

        await _visaTypeRepository.DeleteAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
