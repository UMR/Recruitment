namespace Recruitment.Persistence.Repositories;

public class PostCodeRepository : IPostCodeRepository
{
    private readonly IDapperContext _dapperContext;    

    public PostCodeRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;        
    }

    public async Task<IEnumerable<PostCodeEntity>> GetAllAsync()
    {
        var query = @"SELECT * FROM Lookup_PostCode ORDER BY PostCode ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryAsync<PostCodeEntity>(query);
            return result.ToList();
        }
    }

    public async Task<PostCodeEntity> GetByIdAsync(int id)
    {
        var query = @"SELECT * FROM Lookup_PostCode WHERE PostCodeID=@PostCodeID";

        var parameters = new DynamicParameters();
        parameters.Add("PostCodeID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryFirstOrDefaultAsync<PostCodeEntity>(query, parameters);
            return result;
        }
    }

    public async Task<bool> IsExistPostCodeAsync(string name, int? id = null)
    {
        var query = @"SELECT COUNT(*) FROM Lookup_PostCode WHERE PostCode=@PostCode";

        if (id != null)
        {
            query += " AND PostCodeID != @PostCodeID";
        }

        var parameters = new DynamicParameters();
        parameters.Add("PostCode", name, DbType.String);

        if (id is not null)
        {
            parameters.Add("PostCodeID", id, DbType.Int32);
        }

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteScalarAsync<int>(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<int> CreateAsync(PostCodeEntity model)
    {
        var query = "INSERT INTO Lookup_PostCode (PostCode,CountryId) VALUES (@PostCode,@CountryId) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("PostCode", model.PostCode, DbType.String);
        parameters.Add("CountryId", model.CountryId, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(int id, PostCodeEntity model)
    {
        var query = "UPDATE Lookup_PostCode SET PostCode = @PostCode, CountryId=@CountryId WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("PostCode", model.PostCode, DbType.String);
        parameters.Add("CountryId", model.CountryId, DbType.Int32);
        parameters.Add("PostCodeID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var query = "DELETE FROM Lookup_PostCode WHERE PostCodeID = @PostCodeID";

        var parameters = new DynamicParameters();
        parameters.Add("PostCodeID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
   
}
