namespace Recruitment.Application.Contracts.Persistence;

public interface IRankRepository
{
    Task<IEnumerable<RankLookup>> GetAllAsync();

    Task<RankLookup> GetByIdAsync(int id);
    Task<RankLookup> GetByUserIdAsync(int id);
    Task<bool> DeleteUserRankByUserAsync(int userId);
    Task<bool> AddUserRankAsync(UserRank userRank);
    Task<bool> UpdateUserRankAsync(UserRank userRank);
}
