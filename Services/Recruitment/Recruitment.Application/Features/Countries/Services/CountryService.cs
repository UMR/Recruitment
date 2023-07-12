namespace Recruitment.Application.Features.Countries;

public class CountryService : ICountryService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly ICountryRepository _countryRepository;

    public CountryService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, ICountryRepository countryRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _countryRepository = countryRepository;
    }

    public async Task<List<CountryListDto>> GetAllAsync()
    {
        var entitiesFromRepo = await _countryRepository.GetAllAsync();
        var entitiesToReturn = _mapper.Map<List<CountryListDto>>(entitiesFromRepo);
        return entitiesToReturn;
    }

    public async Task<CountryListDto> GetByIdAsync(int id)
    {
        var entityFromRepo = await _countryRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<CountryListDto>(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistNameAsync(string name, int? id = null)
    {
        return await _countryRepository.IsExistNameAsync(name, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreateCountryDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateCountryDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new Country
        {
            CountryName = request.CountryName,
            Description = request.Description,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _countryRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(int id, UpdateCountryDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateCountryDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.CountryId)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _countryRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(EmailType), id.ToString());
        }

        entity.CountryId = request.CountryId;
        entity.CountryName = request.CountryName;
        entity.Description = request.Description;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _countryRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _countryRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(EmailType), id.ToString());
        }

        var result = await _countryRepository.DeleteAsync(id);

        if (result)
        {
            response.Success = true;
            response.Message = "Deleting Successful";
        }
        else
        {
            response.Success = false;
            response.Message = "Deleting Failed";
        }

        return response;
    }
}
