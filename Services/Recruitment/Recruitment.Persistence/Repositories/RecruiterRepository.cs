using Recruitment.Application.Features.ManageRecruiter;

namespace Recruitment.Persistence.Repositories;

public class RecruiterRepository : IRecruiterRepository
{
    private readonly IDapperContext _dapperContext;

    public RecruiterRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<RecruiterListDto>> GetAllRecruitersAsync()
    {
        try
        {
            var query = @"select UserID,LoginId,FirstName,LastName,Email,Telephone,ODAPermission,Users.IsActive,AgencyName,ApplicantType.ApplicantTypeID,Name from [Users]
                    LEFT JOIN  [Agency] ON [Users].[AgencyID] = [Agency].[AgencyID]
                    LEFT JOIN  ApplicantType ON [Users].ApplicantTypeID = ApplicantType.ApplicantTypeID " +
                    " ORDER BY FirstName,LastName,LoginId";

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var users = await conn.QueryAsync<RecruiterListDto>(query);
                return users.ToList();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<User> GetRecruiterByIdAsync(int id)
    {
        var query = @"SELECT * FROM EmailTypes WHERE ID=@ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var emailType = await conn.QueryFirstOrDefaultAsync<User>(query, parameters);
            return emailType;
        }
    }
    public async Task<int> CreateRecruiterAsync(User emailType)
    {
        var query = "INSERT INTO EmailTypes (Type, IsPersonal, IsOfficial, CreatedBy, CreatedDate) VALUES (@Type, @IsPersonal, @IsOfficial, @CreatedBy, @CreatedDate) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        //parameters.Add("Type", emailType.Type, DbType.String);
        //parameters.Add("IsPersonal", emailType.IsPersonal, DbType.Boolean);
        //parameters.Add("IsOfficial", emailType.IsOfficial, DbType.Boolean);
        parameters.Add("CreatedBy", emailType.CreatedBy, DbType.Int32);
        parameters.Add("CreatedDate", emailType.CreatedDate, DbType.DateTime);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> DeleteRecruiterAsync(long id)
    {
        var query = "DELETE FROM EmailTypes WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public Task<bool> UpdateRecruiterAsync(int id, User user)
    {
        throw new NotImplementedException();
    }
}
