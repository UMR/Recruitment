namespace Recruitment.Persistence.Repositories;

public class UpperCaseWordRepository: IUpperCaseWordRepository
{
    private readonly IDapperContext _dapperContext;

    public UpperCaseWordRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<UpperCaseWord>> GetAllAsync()
    {
        var query = @"SELECT * FROM UpperCaseLookup ORDER BY Word ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryAsync<UpperCaseWord>(query);
            return result.ToList();
        }
    }

    public async Task<UpperCaseWord> GetByIdAsync(long id)
    {
        var query = @"SELECT * FROM UpperCaseLookup WHERE ID=@ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int64);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryFirstOrDefaultAsync<UpperCaseWord>(query, parameters);
            return result;
        }
    }

    public async Task<bool> IsExistWordAsync(string word, long? id = null)
    {
        var query = @"SELECT COUNT(*) FROM UpperCaseLookup WHERE Word=@Word";

        if (id != null)
        {
            query += " AND ID != @ID";
        }

        var parameters = new DynamicParameters();
        parameters.Add("Word", word, DbType.String);

        if (id is not null)
        {
            parameters.Add("ID", id, DbType.Int64);
        }

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteScalarAsync<int>(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<int> CreateAsync(UpperCaseWord model)
    {
        var query = "INSERT INTO UpperCaseLookup (Word) VALUES (@Word) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("Word", model.Word, DbType.String);        

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(long id, UpperCaseWord model)
    {
        var query = "UPDATE UpperCaseLookup SET Word = @Word WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("Word", model.Word, DbType.String);        
        parameters.Add("ID", id, DbType.Int64);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var query = "DELETE FROM UpperCaseLookup WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int64);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
}
