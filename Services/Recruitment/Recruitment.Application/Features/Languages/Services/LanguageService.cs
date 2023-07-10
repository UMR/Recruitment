using Recruitment.Domain.Entities;

namespace Recruitment.Application.Features.Languages;

public class LanguageService : ILanguageService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly ILanguageRepository _languageRepository;

    public LanguageService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, ILanguageRepository languageRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _languageRepository = languageRepository;
    }

    public async Task<List<LanguageListDto>> GetAllAsync()
    {
        var entitiesFromRepo = await _languageRepository.GetAllAsync();
        var entitiesToReturn = _mapper.Map<List<LanguageListDto>>(entitiesFromRepo);
        return entitiesToReturn;
    }

    public async Task<LanguageListDto> GetByIdAsync(int id)
    {
        var entityFromRepo = await _languageRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<LanguageListDto>(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistLanguageAsync(string name, int? id = null)
    {
        return await _languageRepository.IsExistVisaTypeAsync(name, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreateLanguageDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateLanguageDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new Language
        {
            Name = request.Name,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _languageRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(int id, UpdateLanguageDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateLanguageDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.LanguageId)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _languageRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(Language), id.ToString());
        }

        entity.LanguageId = request.LanguageId;
        entity.Name = request.Name;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _languageRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _languageRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(Language), id.ToString());
        }

        var result = await _languageRepository.DeleteAsync(id);

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
