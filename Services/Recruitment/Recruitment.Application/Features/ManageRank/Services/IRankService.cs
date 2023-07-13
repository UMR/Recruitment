namespace Recruitment.Application.Features.ManageRank
{
    public interface IRankService
    {
        Task<List<RankListDto>> GetAllAsync();
        Task<RankListDto> GetByIdAsync(int id);
        Task<RankListDto> GetByUserIdAsync(int userId);
        Task<BaseCommandResponse> AddUserRankAsync(CreateUpdateUserRankDto userRank);
        Task<BaseCommandResponse> UpdateUserRankAsync(int id, CreateUpdateUserRankDto userRank);
    }
}