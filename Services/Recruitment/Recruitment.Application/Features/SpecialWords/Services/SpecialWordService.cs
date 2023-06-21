namespace Recruitment.Application.Features.SpecialWords;

public class SpecailWordService : ISpecialWordService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly ISpecialWordRepository _specialWordRepository;

    public SpecailWordService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, ISpecialWordRepository specialWordRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _specialWordRepository = specialWordRepository;
    }

    public async Task<List<SpecialWordListDto>> GetAllAsync()
    {
        var entitiesFromRepo = await _specialWordRepository.GetAllAsync();
        var entitiesToReturn = _mapper.Map<List<SpecialWordListDto>>(entitiesFromRepo);
        return entitiesToReturn;
    }

    public async Task<SpecialWordListDto> GetByIdAsync(long id)
    {
        var entityFromRepo = await _specialWordRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<SpecialWordListDto>(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistWordAsync(string word, long? id = null)
    {
        return await _specialWordRepository.IsExistWordAsync(word, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreateSpecialWordDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateSpecialWordDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new SpecialWord
        {
            Word = request.Word
        };
        await _specialWordRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(long id, UpdateSpecialWordDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdateSpecialWordDtoValidator(this);
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

        var entity = await _specialWordRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        entity.Id = request.Id;
        entity.Word = request.Word;
        await _specialWordRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(long id)
    {
        var response = new BaseCommandResponse();
        var entity = await _specialWordRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        await _specialWordRepository.DeleteAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
