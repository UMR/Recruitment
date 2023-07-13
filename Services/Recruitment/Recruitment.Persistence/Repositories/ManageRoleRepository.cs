using Recruitment.Application.Features.ManageRole;

namespace Recruitment.Persistence.Repositories;

public class ManageRoleRepository : IManageRoleRepository
{
    private readonly IDapperContext _dapperContext;

    public ManageRoleRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<RoleListDto>> GetAllAsync()
    {
        var query = @"SELECT * FROM [Roles] order by RoleName asc";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var roles = await conn.QueryAsync<RoleListDto>(query);
            return roles.ToList();
        }
    }

    public async Task<Role> GetByIdAsync(int id)
    {
        var query = @"SELECT [RoleID],[RoleName]  FROM [Roles] where [RoleID]=@RoleId";

        var parameters = new DynamicParameters();
        parameters.Add("RoleId", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var role = await conn.QueryFirstOrDefaultAsync<Role>(query, parameters);
            return role;
        }
    }

    public async Task<bool> IsExistAsync(string roleName, int? id = null)
    {
        var query = @"SELECT [RoleID]  FROM [Roles] where [RoleName]=@RoleName";

        if (id != null)
        {
            query += " AND RoleID != @RoleID";
        }

        var parameters = new DynamicParameters();
        parameters.Add("RoleName", roleName, DbType.String);

        if (id is not null)
        {
            parameters.Add("RoleID", id, DbType.Int32);
        }

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteScalarAsync<int>(query, parameters);
            return result > 0 ? true : false;
        }
    }
    private List<Role> GetRoleByName(string roleName)
    {

        string query = @"SELECT RoleID,RoleName,Rank  FROM [Roles] where [RoleName]=@RoleName";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var parameters = new { RoleName = roleName };
            return conn.Query<Role>(query, parameters).ToList();
        }
    }

    public async Task<int> CreateAsync(Role model)
    {
        var query = "INSERT INTO EmailTypes (Type, IsPersonal, IsOfficial, CreatedBy, CreatedDate) VALUES (@Type, @IsPersonal, @IsOfficial, @CreatedBy, @CreatedDate) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("CreatedBy", model.CreatedBy, DbType.Int32);
        parameters.Add("CreatedDate", model.CreatedDate, DbType.DateTime);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(int id, Role model)
    {
        var query = "UPDATE EmailTypes SET Type = @Type, IsPersonal = @IsPersonal, IsOfficial = @IsOfficial, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("Type", model.RoleName, DbType.String);
        parameters.Add("UpdatedBy", model.UpdatedBy, DbType.Int32);
        parameters.Add("UpdatedDate", model.UpdatedDate, DbType.DateTime);
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<string> DeleteAsync(long id)
    {
        string result = string.Empty;

        try
        {
            var query = "DELETE FROM EmailTypes WHERE ID = @ID";

            var parameters = new DynamicParameters();
            parameters.Add("ID", id, DbType.Int32);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                await conn.ExecuteAsync(query, parameters);
            }
        }
        catch (SqlException se)
        {
            if (se.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
            {
                result = "In Use. Can not be deleted.";
            }
        }

        return result;
    }

    public async Task<IEnumerable<RoleListDto>> GetRoleByUserAsync(int userId)
    {
        var query = @"SELECT UR.RoleID,R.RoleName,R.Rank FROM UserRoles UR,Roles R Where UR.RoleID=R.RoleID and UR.UserID=@UserID";

        var parameters = new DynamicParameters();
        parameters.Add("UserID", userId, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var roles = await conn.QueryAsync<RoleListDto>(query, parameters);
            return roles.ToList();
        }
    }
}
