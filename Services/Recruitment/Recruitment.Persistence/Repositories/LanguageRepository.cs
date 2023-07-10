namespace Recruitment.Persistence.Repositories;

public class LanguageRepository : ILanguageRepository
{
    private readonly IDapperContext _dapperContext;

    public LanguageRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<Language>> GetAllAsync()
    {
        var query = @"SELECT * FROM Language ORDER BY Name ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryAsync<Language>(query);
            return result.ToList();
        }
    }

    public async Task<Language> GetByIdAsync(int id)
    {
        var query = @"SELECT * FROM Language WHERE LanguageID=@LanguageID";

        var parameters = new DynamicParameters();
        parameters.Add("LanguageID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryFirstOrDefaultAsync<Language>(query, parameters);
            return result;
        }
    }

    public async Task<bool> IsExistVisaTypeAsync(string visaType, int? id = null)
    {
        var query = @"SELECT COUNT(*) FROM Language WHERE Name=@Name";

        if (id != null)
        {
            query += " AND LanguageID != @LanguageID";
        }

        var parameters = new DynamicParameters();
        parameters.Add("Name", visaType, DbType.String);

        if (id is not null)
        {
            parameters.Add("LanguageID", id, DbType.Int32);
        }

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteScalarAsync<int>(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<int> CreateAsync(Language model)
    {
        var query = "INSERT INTO Language (Name) VALUES (@Name) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("Name", model.Name, DbType.String);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(int id, Language model)
    {
        var query = "UPDATE Language SET Name = @Name WHERE LanguageID = @LanguageID";

        var parameters = new DynamicParameters();
        parameters.Add("Name", model.Name, DbType.String);
        parameters.Add("LanguageID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<string> DeleteAsync(int id)
    {
        string result = string.Empty;

        try
        {
            var query = "DELETE FROM Language WHERE LanguageID = @LanguageID";

            var parameters = new DynamicParameters();
            parameters.Add("LanguageID", id, DbType.Int32);

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
}
