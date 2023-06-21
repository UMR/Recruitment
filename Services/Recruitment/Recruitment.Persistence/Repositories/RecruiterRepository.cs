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
            var query = @"select UserID,LoginId,FirstName,LastName,Email,Telephone,ODAPermission,Users.IsActive,AgencyName,Users.AgencyID,ApplicantType.ApplicantTypeID,Name from [Users]
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
        try
        {
            var query = @"SELECT * FROM [UMRRecruitementDB_New].[dbo].[Users] where UserID=@ID";

            var parameters = new DynamicParameters();
            parameters.Add("ID", id, DbType.Int32);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var user = await conn.QueryFirstOrDefaultAsync<User>(query, parameters);
                return user;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public async Task<int> CreateRecruiterAsync(User emailType)
    {
        try
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
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<bool> DeleteRecruiterAsync(int deleteUserId, int updatedUserId)
    {
        try
        {
            string commentDescription = "User delete at " + DateTime.Now.ToString("MM/dd/yyyy") + " User ID " + deleteUserId;
            if (AddUserActionLog(deleteUserId, commentDescription))
            {
                string spName = "Sp_DeleteUser";

                var parameters = new DynamicParameters();
                parameters.Add("p_DeletedUserId", deleteUserId, DbType.Int32);
                parameters.Add("p_UpdatedUserId", updatedUserId, DbType.Int32);

                using (IDbConnection conn = _dapperContext.CreateConnection)
                {
                    var result = await conn.ExecuteAsync(spName, parameters, null, null, CommandType.StoredProcedure);
                    return result > 0 ? true : false;
                }
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public bool AddUserActionLog(int userId, string actionComment)
    {

        try
        {
            string query = @"INSERT INTO [dbo].[UserActionLog]
                                        ([UserID]
                                        ,[ActionComment])
                                    VALUES
                                       (@UserID
                                       ,@ActionComment)";

            var parameters = new DynamicParameters();
            parameters.Add("UserID", userId, DbType.Int32);
            parameters.Add("ActionComment", actionComment, DbType.String);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var result = conn.Execute(query, parameters);
                return result > 0 ? true : false;
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
    public Task<bool> UpdateRecruiterAsync(int id, User user)
    {
        throw new NotImplementedException();
    }
}
