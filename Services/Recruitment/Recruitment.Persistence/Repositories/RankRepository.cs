namespace Recruitment.Persistence.Repositories;

public class RankRepository : IRankRepository
{
    private readonly IDapperContext _dapperContext;

    public RankRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<RankLookup>> GetAllAsync()
    {
        var query = @"SELECT [RankLookupID], [EnumID], [Rank] FROM [RankLookup] ORDER BY Rank ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var ranks = await conn.QueryAsync<RankLookup>(query);
            return ranks.ToList();
        }
    }

    public async Task<RankLookup> GetByIdAsync(int id)
    {
        var query = @"SELECT [EnumID] FROM [RankLookup] WHERE RankLookupID = @RankLookupID";

        var parameters = new DynamicParameters();
        parameters.Add("RankLookupID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var rank = await conn.QueryFirstOrDefaultAsync<RankLookup>(query, parameters);
            return rank;
        }
    }

    public async Task<RankLookup> GetByUserIdAsync(int userId)
    {
        var query = @"SELECT [RankLookup].[RankLookupID], [RankLookup].[EnumID], [Rank] 
                          FROM [dbo].[UserRank]
                          LEFT JOIN[dbo].[RankLookup] ON[dbo].[RankLookup].RankLookupID = [dbo].[UserRank].RankLookupID
                          WHERE[dbo].[UserRank].UserID = @UserID";

        var parameters = new DynamicParameters();
        parameters.Add("UserID", userId, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var rank = await conn.QueryFirstOrDefaultAsync<RankLookup>(query, parameters);
            return rank;
        }
    }

    public async Task<bool> DeleteUserRoleByUserAsync(int userId) {

        var query = @"DELETE FROM [UserRank] WHERE [UserID]=@UserID";

        return true;
        //var parameters = new DynamicParameters();
        //parameters.Add("UserID", userId, DbType.Int32);

        //using (IDbConnection conn = _dapperContext.CreateConnection)
        //{
        //    var rank = await conn.QueryFirstOrDefaultAsync<RankLookup>(query, parameters);
        //    return rank;
        //}
    }
}
