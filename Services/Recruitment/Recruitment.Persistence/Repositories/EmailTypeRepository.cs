namespace Recruitment.Persistence.Repositories;

public class EmailTypeRepository : IEmailTypeRepository
{
    private readonly IDapperContext _dapperContext;

    public EmailTypeRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<EmailType>> GetEmailTypesAsync()
    {
        var query = @"SELECT * FROM EmailTypes ORDER BY Type ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var emailTypes = await conn.QueryAsync<EmailType>(query);
            return emailTypes.ToList();
        }
    }

    public async Task<EmailType> GetEmailTypeByIdAsync(int id)
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

    public async Task<int> CreateEmailTypeAsync(EmailType emailType)
    {
        var query = "INSERT INTO EmailTypes (Type, IsPersonal, IsOfficial, CreatedBy, CreatedDate) VALUES (@Type, @IsPersonal, @IsOfficial, @CreatedBy, @CreatedDate) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("Type", emailType.Type, DbType.String);
        parameters.Add("IsPersonal", emailType.IsPersonal, DbType.Boolean);
        parameters.Add("IsOfficial", emailType.IsOfficial, DbType.Boolean);
        parameters.Add("CreatedBy", emailType.CreatedBy, DbType.Int32);
        parameters.Add("CreatedDate", emailType.CreatedDate, DbType.DateTime);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateEmailTypeAsync(int id, EmailType emailType)
    {
        var query = "UPDATE EmailTypes SET Type = @Type, IsPersonal = @IsPersonal, IsOfficial = @IsOfficial, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("Type", emailType.Type, DbType.String);
        parameters.Add("IsPersonal", emailType.IsPersonal, DbType.Boolean);
        parameters.Add("IsOfficial", emailType.IsOfficial, DbType.Boolean);
        parameters.Add("UpdatedBy", emailType.UpdatedBy, DbType.Int32);
        parameters.Add("UpdatedDate", emailType.UpdatedDate, DbType.DateTime);
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<bool> DeleteEmailTypeAsync(long id)
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
}
