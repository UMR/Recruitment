namespace Recruitment.Application.Features.InstitutionTypes;

public class InstitutionTypeService : IInstitutionTypeService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IInstitutionTypeRepository _institutionTypeRepository;

    public InstitutionTypeService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IInstitutionTypeRepository institutionTypeRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _institutionTypeRepository = institutionTypeRepository;
    }
    public async Task<List<InstitutionTypeListDto>> GetInstitutionTypesAsync()
    {
        var institutionTypesFromRepo = await _institutionTypeRepository.GetInstitutionTypesAsync();
        //var institutionTypesToReturn = _mapper.Map<List<InstitutionTypeListDto>>(institutionTypesFromRepo);

        List<InstitutionTypeListDto> institutionTypeListDto = new List<InstitutionTypeListDto>();
        foreach (var institutionType in institutionTypesFromRepo)
        {
            InstitutionTypeListDto institutionTypeList = new InstitutionTypeListDto();
            institutionTypeList.Description = institutionType.Description;
            institutionTypeList.InstituteTypeId = institutionType.InstituteTypeId;
            institutionTypeList.InstituteType = institutionType.InstituteType;
            institutionTypeListDto.Add(institutionTypeList);
        }
        return institutionTypeListDto;
    }
    public async Task<InstitutionTypeListDto> GetInstitutionTypeByIdAsync(int id)
    {
        var institutionTypeFromRepo = await _institutionTypeRepository.GetInstitutionTypeByIdAsync(id);
        var institutionTypeToReturn = _mapper.Map<InstitutionTypeListDto>(institutionTypeFromRepo);
        return institutionTypeToReturn;
    }
    public async Task<BaseCommandResponse> CreateInstitutionTypeAsync(CreateInstitutionTypeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateInstitutionTypeDtoValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new InstituteTypeTable
        {
            InstituteType = request.InstituteType,
            Description = request.Description,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _institutionTypeRepository.CreateInstitutionTypeAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }
    public async Task<BaseCommandResponse> UpdateInstitutionTypeAsync(int id, UpdateInstitutionTypeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateInstitutionTypeDtoValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.InstituteTypeID)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _institutionTypeRepository.GetInstitutionTypeByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        entity.InstituteTypeId = request.InstituteTypeID;
        entity.InstituteType = request.InstituteType;
        entity.Description = request.Description;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _institutionTypeRepository.UpdateInstitutionTypeAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }
    public async Task<BaseCommandResponse> DeleteInstitutionTypeAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _institutionTypeRepository.GetInstitutionTypeByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        await _institutionTypeRepository.DeleteInstitutionTypeAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
