namespace Recruitment.Application.Features.PostCodes;

public class PostCodeService : IPostCodeService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IPostCodeRepository _postCodeRepository;

    public PostCodeService(IMapper mapper, ICurrentUserService currentUserService, IDateTimeService dateTime, IPostCodeRepository postCodeRepository)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _postCodeRepository = postCodeRepository;
    }

    public async Task<List<PostCodeListDto>> GetAllAsync()
    {
        var entitiesFromRepo = await _postCodeRepository.GetAllAsync();
        var entitiesToReturn = _mapper.Map<List<PostCodeListDto>>(entitiesFromRepo);
        return entitiesToReturn;
    }

    public async Task<PostCodeListDto> GetByIdAsync(int id)
    {
        var entityFromRepo = await _postCodeRepository.GetByIdAsync(id);
        var entityToReturn = _mapper.Map<PostCodeListDto>(entityFromRepo);
        return entityToReturn;
    }

    public async Task<bool> IsExistPostCodeAsync(string name, int? id = null)
    {
        return await _postCodeRepository.IsExistPostCodeAsync(name, id);
    }

    public async Task<BaseCommandResponse> CreateAsync(CreatePostCodeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new CreatePostCodeDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        var entity = new PostCode
        {
            PostCodeName = request.PostCode,
            CountryId = request.CountryId,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _postCodeRepository.CreateAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateAsync(int id, UpdatePostCodeDto request)
    {
        var response = new BaseCommandResponse();
        var validator = new UpdatePostCodeDtoValidator(this);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Updating Failed";
            response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
            return response;
        }

        if (id != request.PostCodeId)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _postCodeRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(VisaTypeEntity), id.ToString());
        }

        entity.PostCodeId = request.PostCodeId;
        entity.PostCodeName = request.PostCode;
        entity.CountryId = request.CountryId;
        entity.UpdatedBy = _currentUserService.UserId;
        entity.UpdatedDate = _dateTime.Now;
        await _postCodeRepository.UpdateAsync(id, entity);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> DeleteAsync(int id)
    {
        var response = new BaseCommandResponse();
        var entity = await _postCodeRepository.GetByIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(PostCode), id.ToString());
        }

        await _postCodeRepository.DeleteAsync(id);

        response.Success = true;
        response.Message = "Deleting Successful";
        return response;
    }
}
