namespace Recruitment.Persistence.Repositories;

public class EmailTypeRepository : IEmailTypeRepository
{
    private readonly IDapperContext _dapperContext;

    public EmailTypeRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<EmailType>> GetAllAsync()
    {
        var query = @"SELECT * FROM EmailTypes ORDER BY Type ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var emailTypes = await conn.QueryAsync<EmailType>(query);
            return emailTypes.ToList();
        }
    }

    public async Task<EmailType> GetByIdAsync(int id)
    {
        var query = @"SELECT * FROM EmailTypes WHERE ID=@ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var emailType = await conn.QueryFirstOrDefaultAsync<EmailType>(query, parameters);
            return emailType;
        }
    }

    public async Task<bool> IsExistAsync(string emailType, int? id = null)
    {
        var query = @"SELECT COUNT(*) FROM EmailTypes WHERE Type=@Type";

        if (id != null)
        {
            query += " AND ID != @ID";
        }

        var parameters = new DynamicParameters();
        parameters.Add("Type", emailType, DbType.String);

        if (id is not null)
        {
            parameters.Add("ID", id, DbType.Int32);
        }

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteScalarAsync<int>(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<int> CreateAsync(EmailType model)
    {
        var query = "INSERT INTO EmailTypes (Type, IsPersonal, IsOfficial, CreatedBy, CreatedDate) VALUES (@Type, @IsPersonal, @IsOfficial, @CreatedBy, @CreatedDate) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("Type", model.Type, DbType.String);
        parameters.Add("IsPersonal", model.IsPersonal, DbType.Boolean);
        parameters.Add("IsOfficial", model.IsOfficial, DbType.Boolean);
        parameters.Add("CreatedBy", model.CreatedBy, DbType.Int32);
        parameters.Add("CreatedDate", model.CreatedDate, DbType.DateTime);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(int id, EmailType model)
    {
        var query = "UPDATE EmailTypes SET Type = @Type, IsPersonal = @IsPersonal, IsOfficial = @IsOfficial, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("Type", model.Type, DbType.String);
        parameters.Add("IsPersonal", model.IsPersonal, DbType.Boolean);
        parameters.Add("IsOfficial", model.IsOfficial, DbType.Boolean);
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
            if (se.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint")) {
                result = "In Use. Can not be deleted.";
            }
        }        

        return result;
    }
}
