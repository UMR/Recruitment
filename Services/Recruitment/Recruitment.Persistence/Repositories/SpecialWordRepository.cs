namespace Recruitment.Persistence.Repositories;

public class SpecialWordRepository:ISpecialWordRepository
{
    private readonly IDapperContext _dapperContext;

    public SpecialWordRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<SpecialWord>> GetAllAsync()
    {
        var query = @"SELECT * FROM SpecialCaseLookup ORDER BY Word ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryAsync<SpecialWord>(query);
            return result.ToList();
        }
    }

    public async Task<SpecialWord> GetByIdAsync(long id)
    {
        var query = @"SELECT * FROM SpecialCaseLookup WHERE ID=@ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int64);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryFirstOrDefaultAsync<SpecialWord>(query, parameters);
            return result;
        }
    }

    public async Task<bool> IsExistWordAsync(string word, long? id = null)
    {
        var query = @"SELECT COUNT(*) FROM SpecialCaseLookup WHERE Word=@Word";

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

    public async Task<int> CreateAsync(SpecialWord model)
    {
        var query = "INSERT INTO SpecialCaseLookup (Word) VALUES (@Word) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("Word", model.Word, DbType.String);        

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(long id, SpecialWord model)
    {
        var query = "UPDATE SpecialCaseLookup SET Word = @Word WHERE ID = @ID";

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
        var query = "DELETE FROM SpecialCaseLookup WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int64);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
}
