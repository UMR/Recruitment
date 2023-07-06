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
                    LEFT JOIN  ApplicantType ON [Users].ApplicantTypeID = ApplicantType.ApplicantTypeID ";
            string filterString = string.Empty;

            if (!string.IsNullOrEmpty(searchRecruiterParamDto.FirstName))
            {
                filterString = "FirstName like '" + searchRecruiterParamDto.FirstName + "%'";
            }
            if(string.IsNullOrEmpty(filterString) && !string.IsNullOrEmpty(searchRecruiterParamDto.LastName))
            {
                filterString = "LastName like '" + searchRecruiterParamDto.LastName + "%'";
            }
            else if (!string.IsNullOrEmpty(filterString) && !string.IsNullOrEmpty(searchRecruiterParamDto.LastName))
            {
                filterString = filterString + " AND " + "LastName like '" + searchRecruiterParamDto.LastName + "%'";
            }
             if(string.IsNullOrEmpty(filterString) && !string.IsNullOrEmpty(searchRecruiterParamDto.Email))
            {
                filterString = "Email like '" + searchRecruiterParamDto.Email + "%'";
            }
            else if (!string.IsNullOrEmpty(filterString) && !string.IsNullOrEmpty(searchRecruiterParamDto.Email))
            {
                filterString = filterString + " AND " + "Email like '" + searchRecruiterParamDto.Email + "%'";
            }
            if (string.IsNullOrEmpty(filterString) && !string.IsNullOrEmpty(searchRecruiterParamDto.Status))
            {
                filterString = "Users.IsActive = " + searchRecruiterParamDto.Status;
            }
            else if (!string.IsNullOrEmpty(filterString) && !string.IsNullOrEmpty(searchRecruiterParamDto.Status))
            {
                filterString = filterString + " AND " + "Users.IsActive = " + searchRecruiterParamDto.Status;
            }
            if (!string.IsNullOrEmpty(filterString))
            {
                filterString = " Where " + filterString + " ORDER BY FirstName,LastName,LoginId";
            }
            else
            {
                filterString = " ORDER BY FirstName,LastName,LoginId";
            }
            query = query + filterString;

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
        catch (Exception)
        {
            throw;
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
        catch (Exception)
        {
            throw;
        }
    }
    public async Task<bool> UpdateRecruiterAsync(int id, User user)
    {
        try
        {
            if (GetUserStatus(user.UserId) != user.IsActive)
            {
                if (UpdateUser(user))
                {
                    var result = await AddUserStatusHistory(user.UserId, user.IsActive, user.IsActive, user.UserId);
                    return result;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                var result = UpdateUser(user);
                return result;
            }

        }
        catch (Exception)
        {
            throw;
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
        catch (Exception)
        {
            throw;
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
    public bool UpdateUser(User user)
    {
        string query = @"UPDATE [Users] SET 
                                    [FirstName] = @FirstName
                                    ,[LastName] = @LastName
                                    ,[Password] = @Password
                                    ,[Email] = @Email
                                    ,[Telephone] = @Telephone
                                    ,[ODAPermission] = @Permission
                                    ,[IsActive] = @IsActive
                                    ,[TimeOut] = @TimeOut
                                    ,[UpdatedBy] = @UpdatedBy
                                    ,[UpdatedDate] = @UpdatedDate
                                    ,[AgencyID]=@AgencyID
                                    ,[ApplicantTypeID]=@ApplicantTypeID
                               WHERE [LoginId]=@LoginId";

        var paramList = new DynamicParameters();
        paramList.Add("FirstName", user.FirstName, DbType.String);
        paramList.Add("LastName", user.LastName, DbType.String);
        paramList.Add("Password", user.Password, DbType.String);
        paramList.Add("Email", user.Email, DbType.String);
        paramList.Add("Telephone", user.Telephone, DbType.String);
        paramList.Add("Permission", user.Odapermission, DbType.Boolean);
        paramList.Add("IsActive", user.IsActive, DbType.Boolean);
        paramList.Add("UpdatedBy", user.UserId, DbType.Int32);
        paramList.Add("UpdatedDate", DateTime.Now, DbType.DateTime);
        paramList.Add("LoginId", user.LoginId, DbType.String);
        paramList.Add("TimeOut", user.TimeOut, DbType.Int32);
        paramList.Add("AgencyID", user.AgencyId, DbType.Int64);
        paramList.Add("ApplicantTypeID", user.ApplicantTypeId, DbType.Int64);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = conn.Execute(query, paramList);
            return result > 0 ? true : false;
        }
    }
    public async Task<bool> AddUserStatusHistory(int userId, bool? fromStatus, bool? toStatus, int createdBy)
    {
        try
        {
            string query = @"INSERT INTO [UserStatusHistory]([UserID],[FromStatus],[ToStatus],[CreatedBy],[CreatedDate]) VALUES(@UserID,@FromStatus,@ToStatus,@CreatedBy,@CreatedDate)";

            var parameters = new DynamicParameters();
            parameters.Add("UserID", userId, DbType.Int32);
            parameters.Add("FromStatus", fromStatus, DbType.Boolean);
            parameters.Add("ToStatus", toStatus, DbType.Boolean);
            parameters.Add("CreatedBy", createdBy, DbType.Int32);
            parameters.Add("CreatedDate", DateTime.Now, DbType.DateTime);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var result = await conn.ExecuteAsync(query, parameters);
                return result > 0 ? true : false;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }


    private bool GetUserStatus(int userId)
    {
        try
        {
            var query = @"SELECT IsActive FROM [UMRRecruitementDB_New].[dbo].[Users] where UserID = @UserId";

            var parameters = new DynamicParameters();
            parameters.Add("UserId", userId, DbType.Int32);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var user = conn.QueryFirstOrDefault<bool>(query, parameters);
                return user;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}
