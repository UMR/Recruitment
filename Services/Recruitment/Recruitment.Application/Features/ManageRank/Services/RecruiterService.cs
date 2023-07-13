namespace Recruitment.Application.Features.ManageRank;

public class RankService : IRankService
{
    private readonly IMapper _mapper;
    private readonly IRankRepository _rankRepository;

    public RankService(IMapper mapper, IRankRepository rankRepository)
    {
        _mapper = mapper;
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
}
