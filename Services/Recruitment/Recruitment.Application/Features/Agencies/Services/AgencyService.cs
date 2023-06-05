namespace Recruitment.Application.Features.Agencies;

public class AgencyService : IAgencyService
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

    public async Task<List<AgencyListDto>> GetAgencies()
    {            
        var agenciesFromRepo = await _agencyRepository.GetAgencies();
        var agenciesToReturn = _mapper.Map<List<AgencyListDto>>(agenciesFromRepo);
        return agenciesToReturn;
    }

    public async Task<AgencyListDto> GetAgencyById(int id)
    {
        var agencyFromRepo = await _agencyRepository.GetAgencyById(id);
        var agencyToReturn = _mapper.Map<AgencyListDto>(agencyFromRepo);
        return agencyToReturn;
    }

    public async Task<BaseCommandResponse> CreateAgency(CreateAgencyDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateAgencyDtoValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = _mapper.Map<Agency>(request);
        entity.CreatedBy = _currentUserService.UserId;
        entity.CreatedDate = _dateTime.Now;

        await _agencyRepository.CreateAgency(entity);

        response.Success = true;
        response.Message = "Creating Successful";    
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAgency(int id, UpdateAgencyDto request) 
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

        var isExistEntity = await _agencyRepository.GetAgencyById(id);
        
        if (isExistEntity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        var entity = _mapper.Map<Agency>(isExistEntity);
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _agencyRepository.UpdateAgency(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAgency(int id) 
    {
        var response = new BaseCommandResponse();
        var isExistEntity = await _agencyRepository.GetAgencyById(id);

        if (isExistEntity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }
        
        await _agencyRepository.DeleteAgency(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
