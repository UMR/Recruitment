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
            var query = @"select UserID,LoginId,FirstName,LastName,Email,Telephone,ODAPermission,TimeOut,Users.IsActive,AgencyName,Users.AgencyID,ApplicantType.ApplicantTypeID,Name from [Users]
                    LEFT JOIN  [Agency] ON [Users].[AgencyID] = [Agency].[AgencyID]
                    LEFT JOIN  ApplicantType ON [Users].ApplicantTypeID = ApplicantType.ApplicantTypeID " +
                    " ORDER BY FirstName,LastName,LoginId";

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var users = await conn.QueryAsync<RecruiterListDto>(query);
                return users.ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task<IEnumerable<RecruiterListDto>> GetAllRecruitersByAsync(SearchRecruiterParamDto searchRecruiterParamDto)
    {
        try
        {
            var query = @"select UserID,LoginId,FirstName,LastName,Email,Telephone,ODAPermission,TimeOut,Users.IsActive,AgencyName,Users.AgencyID,ApplicantType.ApplicantTypeID,Name from [Users]
                    LEFT JOIN  [Agency] ON [Users].[AgencyID] = [Agency].[AgencyID]
                    LEFT JOIN  ApplicantType ON [Users].ApplicantTypeID = ApplicantType.ApplicantTypeID " +
                    " ORDER BY FirstName,LastName,LoginId";

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var users = await conn.QueryAsync<RecruiterListDto>(query);
                return users.ToList();
            }
        }
        catch (Exception)
        {
            throw;
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
    public async Task<int> CreateRecruiterAsync(User user)
    {
        try
        {
            var query = "INSERT INTO [Users](LoginId,FirstName,LastName,Password,Email,Telephone,ODAPermission,[CreatedBy],[CreatedDate],[TimeOut],[AgencyID],[ApplicantTypeID])" +
                               "VALUES(@LoginId, @FirstName, @LastName, @Password, @Email, @Telephone, @Permission, @CreatedBy, @CreatedDate, @TimeOut, @AgencyID, @ApplicantTypeID)";

            var parameters = new DynamicParameters();
            parameters.Add("LoginId", user.LoginId, DbType.String);
            parameters.Add("FirstName", user.FirstName, DbType.String);
            parameters.Add("LastName", user.LastName, DbType.String);
            parameters.Add("Password", user.Password, DbType.String);
            parameters.Add("Email", user.Email, DbType.String);
            parameters.Add("Telephone", user.Telephone, DbType.String);
            parameters.Add("Permission", true, DbType.Boolean);
            parameters.Add("TimeOut", user.TimeOut, DbType.Int32);
            parameters.Add("AgencyID", user.AgencyId, DbType.Int64);
            parameters.Add("ApplicantTypeID", user.ApplicantTypeId, DbType.Int64);
            parameters.Add("CreatedBy", user.CreatedBy, DbType.Int32);
            parameters.Add("CreatedDate", user.CreatedDate, DbType.DateTime);

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
    public Task<bool> UpdateRecruiterAsync(int id, User user)
    {
        throw new NotImplementedException();
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
    private bool AddUserActionLog(int userId, string actionComment)
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

}
