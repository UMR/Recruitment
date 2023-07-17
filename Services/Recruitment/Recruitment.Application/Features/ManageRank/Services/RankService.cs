namespace Recruitment.Application.Features.ManageRank;

public class RankService : IRankService
{
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTime;
    private readonly IRankRepository _rankRepository;

    public RankService(IMapper mapper, IRankRepository rankRepository, ICurrentUserService currentUserService, IDateTimeService dateTime)
    {
        _mapper = mapper;
        _currentUserService = currentUserService;
        _dateTime = dateTime;
        _rankRepository = rankRepository;
    }

    async Task<List<RankListDto>> IRankService.GetAllAsync()
    {
        var rankFromRepo = await _rankRepository.GetAllAsync();
        var rankToReturn = _mapper.Map<List<RankListDto>>(rankFromRepo);
        return rankToReturn;
    }

    public async Task<RankListDto> GetByIdAsync(int id)
    {
        var rankFromRepo = await _rankRepository.GetByIdAsync(id);
        var rankToReturn = _mapper.Map<RankListDto>(rankFromRepo);
        return rankToReturn;
    }

    public async Task<RankListDto> GetByUserIdAsync(int userId)
    {
        var rankFromRepo = await _rankRepository.GetByUserIdAsync(userId);
        var rankToReturn = _mapper.Map<RankListDto>(rankFromRepo);
        return rankToReturn;
    }

    public async Task<BaseCommandResponse> AddUserRankAsync(CreateUpdateUserRankDto request)
    {
        var response = new BaseCommandResponse();
        //var validator = new CreateAgencyDtoValidator(this);
        //var validationResult = await validator.ValidateAsync(request);

        //if (validationResult.IsValid == false)
        //{
        //    response.Success = false;
        //    response.Message = "Creating Failed";
        //    response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
        //    return response;
        //}

        var entity = new CreateUpdateUserRankDto
        {
            RankLookupId = request.RankLookupId,
            EnumId = request.EnumId,
            UserId = request.UserId,
            CreatedBy = _currentUserService.UserId,
            CreatedDate = _dateTime.Now
        };
        await _rankRepository.AddUserRankAsync(entity);

        response.Success = true;
        response.Message = "Creating Successful";
        return response;
    }

    public async Task<BaseCommandResponse> UpdateUserRankAsync(int id, CreateUpdateUserRankDto request)
    {
        var response = new BaseCommandResponse();
        //var validator = new UpdateAgencyDtoValidator(this);
        //var validationResult = await validator.ValidateAsync(request);

        //if (validationResult.IsValid == false)
        //{
        //    response.Success = false;
        //    response.Message = "Updating Failed";
        //    response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
        //    return response;
        //}

        if (id != request.UserId)
        {
            throw new BadRequestException("Id does not match");
        }

        var entity = await _rankRepository.GetByUserIdAsync(id);

        if (entity is null)
        {
            throw new NotFoundException(nameof(User), id.ToString());
        }

        CreateUpdateUserRankDto obj = new CreateUpdateUserRankDto();

        obj.RankLookupId = request.RankLookupId;
        obj.EnumId = request.EnumId;
        obj.UpdatedBy = _currentUserService.UserId;
        obj.UpdatedDate = _dateTime.Now;
        obj.CreatedDate = _dateTime.Now;
        obj.UserId = request.UserId;

        await _rankRepository.UpdateUserRankAsync(obj);

        response.Success = true;
        response.Message = "Updating Successful";
        return response;
    }
}
