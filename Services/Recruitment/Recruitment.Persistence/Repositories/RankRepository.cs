using Recruitment.Application.Features.ManageRank;

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
    public async Task<bool> AddUserRankAsync(CreateUpdateUserRankDto userRank)
    {
        var query = "INSERT INTO [UserRank] ([UserID],[RankLookupID],[EnumID],[CreatedBy],[CreatedDate]) VALUES (@UserID, @RankLookupID, @EnumID, @CreatedBy, @CreatedDate)";

        var parameters = new DynamicParameters();
        parameters.Add("UserID", userRank.UserId, DbType.String);
        parameters.Add("RankLookupID", userRank.RankLookupId, DbType.String);
        parameters.Add("EnumID", userRank.EnumId, DbType.Int32);
        parameters.Add("CreatedBy", userRank.CreatedBy, DbType.Int32);
        parameters.Add("CreatedDate", DateTime.Now, DbType.DateTime);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
    public async Task<bool> UpdateUserRankAsync(CreateUpdateUserRankDto userRank)
    {
        var query = "UPDATE [dbo].[UserRank] SET[RankLookupID] = @RankLookupID ,[UpdatedBy] = @UpdatedBy ,[UpdatedDate] = @UpdatedDate,[EnumID] = @EnumID WHERE UserID = @UserID";

        var parameters = new DynamicParameters();
        parameters.Add("RankLookupID", userRank.RankLookupId, DbType.String);
        parameters.Add("EnumID", userRank.EnumId, DbType.String);
        parameters.Add("UserID", userRank.UserId, DbType.String);
        parameters.Add("UpdatedBy", userRank.UpdatedBy, DbType.Int32);
        parameters.Add("UpdatedDate", DateTime.Now, DbType.DateTime);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
    public async Task<bool> DeleteUserRankByUserAsync(int userId)
    {

        var query = @"DELETE FROM [UserRank] WHERE [UserID]=@UserID";

        var parameters = new DynamicParameters();
        parameters.Add("UserID", userId, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
}
