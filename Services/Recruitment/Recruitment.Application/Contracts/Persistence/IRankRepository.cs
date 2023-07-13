namespace Recruitment.Application.Contracts.Persistence;

public interface IRankRepository
{
    Task<IEnumerable<RankLookup>> GetAllAsync();

    Task<RankLookup> GetByIdAsync(int id);
    Task<RankLookup> GetByUserIdAsync(int id);
    Task<bool> DeleteUserRankByUserAsync(int userId);
    Task<bool> AddUserRankAsync(CreateUpdateUserRankDto userRank);
    Task<bool> UpdateUserRankAsync(CreateUpdateUserRankDto userRank);
}
