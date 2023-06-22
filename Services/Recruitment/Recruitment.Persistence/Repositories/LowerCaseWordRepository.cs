namespace Recruitment.Persistence.Repositories;

public class LowerCaseWordRepository:ILowerCaseWordRepository
{
    private readonly IDapperContext _dapperContext;

    public LowerCaseWordRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<LowerCaseWord>> GetAllAsync()
    {
        var query = @"SELECT * FROM LowerCaseLookup ORDER BY Word ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryAsync<LowerCaseWord>(query);
            return result.ToList();
        }
    }

    public async Task<LowerCaseWord> GetByIdAsync(long id)
    {
        var query = @"SELECT * FROM LowerCaseLookup WHERE ID=@ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int64);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryFirstOrDefaultAsync<LowerCaseWord>(query, parameters);
            return result;
        }
    }

    public async Task<bool> IsExistWordAsync(string word, long? id = null)
    {
        var query = @"SELECT COUNT(*) FROM LowerCaseLookup WHERE Word=@Word";

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

    public async Task<int> CreateAsync(LowerCaseWord model)
    {
        var query = "INSERT INTO LowerCaseLookup (Word) VALUES (@Word) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("Word", model.Word, DbType.String);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(long id, LowerCaseWord model)
    {
        var query = "UPDATE LowerCaseLookup SET Word = @Word WHERE ID = @ID";

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
        var query = "DELETE FROM LowerCaseLookup WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int64);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
}
