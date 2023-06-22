namespace Recruitment.Application.Features.LowerCaseWords;

public class LowerCaseWordService : ILowerCaseWordService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly ILowerCaseWordRepository _lowerCaseWordRepository;

    public LowerCaseWordService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, ILowerCaseWordRepository lowerCaseWordRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _lowerCaseWordRepository = lowerCaseWordRepository;
    }

    public async Task<List<LowerCaseWordListDto>> GetAllAsync()
    {
        var entitiesFromRepo = await _lowerCaseWordRepository.GetAllAsync();
        var entitiesToReturn = _mapper.Map<List<LowerCaseWordListDto>>(entitiesFromRepo);
        return entitiesToReturn;
    }

    public async Task<LowerCaseWordListDto> GetByIdAsync(long id)
    {
        var entityFromRepo = await _lowerCaseWordRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<LowerCaseWordListDto >(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistWordAsync(string word, long? id = null)
    {
        return await _lowerCaseWordRepository.IsExistWordAsync(word, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreateUpperCaseWordDto request)
    {
        var response = new BaseCommandResponse();
        //var validator = new CreateUpperCaseWordDtoValidator(this);
        //var validationResult = await validator.ValidateAsync(request);

        //if (validationResult.IsValid == false)
        //{
        //    response.Success = false;
        //    response.Message = "Creating Failed";
        //    response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
        //    return response;
        //}

        //var entity = new UpperCaseWord
        //{
        //    Word = request.Word
        //};
        //await _upperCaseWordRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(long id, UpdateUpperCaseWordDto request)
    {
        var response = new BaseCommandResponse();
        //var validator = new UpdateUpperCaseWordDtoValidator(this);
        //var validationResult = await validator.ValidateAsync(request);

        //if (validationResult.IsValid == false)
        //{
        //    response.Success = false;
        //    response.Message = "Updating Failed";
        //    response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
        //    return response;
        //}

        //if (id != request.Id)
        //{
        //    throw new BadRequestException("Id does not match");
        //}

        //var entity = await _upperCaseWordRepository.GetByIdAsync(id);

        //if (entity is null)
        //{
        //    throw new NotFoundException(nameof(User), id.ToString());
        //}

        //entity.Id = request.Id;
        //entity.Word = request.Word;
        //await _upperCaseWordRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(long id)
    {
        var response = new BaseCommandResponse();
        var entity = await _lowerCaseWordRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        await _lowerCaseWordRepository.DeleteAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
