namespace Recruitment.Persistence.Repositories;

public class CountryRepository : ICountryRepository
{
    private readonly IDapperContext _dapperContext;

    public CountryRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<Country>> GetAllAsync()
    {
        var query = @"SELECT * FROM Country ORDER BY CountryName ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryAsync<Country>(query);
            return result.ToList();
        }
    }

    public async Task<Country> GetByIdAsync(int id)
    {
        var query = @"SELECT * FROM Country WHERE CountryId=@CountryId";

        var parameters = new DynamicParameters();
        parameters.Add("CountryId", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryFirstOrDefaultAsync<Country>(query, parameters);
            return result;
        }
    }

    public async Task<bool> IsExistCountryAsync(string name, int? id = null)
    {
        var query = @"SELECT COUNT(*) FROM Country WHERE CountryName=@CountryName";

        if (id != null)
        {
            query += " AND CountryId != @CountryId";
        }

        var parameters = new DynamicParameters();
        parameters.Add("CountryName", name, DbType.String);

        if (id is not null)
        {
            parameters.Add("CountryId", id, DbType.Int32);
        }

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteScalarAsync<int>(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<int> CreateAsync(Country model)
    {
        var query = "INSERT INTO Country (CountryName, Description, CreatedBy, CreatedDate) VALUES (@CountryName, @Description, @CreatedBy, @CreatedDate) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("CountryName", model.CountryName, DbType.String);
        parameters.Add("Description", model.Description, DbType.String);
        parameters.Add("CreatedBy", model.CreatedBy, DbType.Int32);
        parameters.Add("CreatedDate", model.CreatedDate, DbType.DateTime);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(int id, Country model)
    {
        var query = "UPDATE Country SET CountryName = @CountryName, Description = @Description, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate " +
            "WHERE CountryId = @CountryId";

        var parameters = new DynamicParameters();
        parameters.Add("CountryName", model.CountryName, DbType.String);
        parameters.Add("Description", model.Description, DbType.String);
        parameters.Add("UpdatedBy", model.UpdatedBy, DbType.Int32);
        parameters.Add("UpdatedDate", model.UpdatedDate, DbType.DateTime);
        parameters.Add("CountryId", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var result = 0;
        var query = "DELETE FROM Country WHERE CountryId = @CountryId";

        var parameters = new DynamicParameters();
        parameters.Add("CountryId", id, DbType.Int32);

        try
        {
            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                result = await conn.ExecuteAsync(query, parameters);
            }
        }
        catch (SqlException se)
        {
            if (se.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
            {
                throw new ConflictException("In Use. Can not be deleted.");
            }
        }

        return result > 0 ? true : false;
    }
}
