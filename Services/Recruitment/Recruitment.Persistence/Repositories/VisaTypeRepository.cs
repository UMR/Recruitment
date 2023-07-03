namespace Recruitment.Persistence.Repositories;

public class VisaTypeRepository:IVisaTypeRepository
{
    private readonly IDapperContext _dapperContext;

    public VisaTypeRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<VisaType>> GetAllAsync()
    {
        var query = @"SELECT * FROM VisaType ORDER BY VisaType ASC";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryAsync<VisaType>(query);
            return result.ToList();
        }
    }

    public async Task<VisaType> GetByIdAsync(int id)
    {
        var query = @"SELECT * FROM VisaType WHERE ID=@ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.QueryFirstOrDefaultAsync<VisaType>(query, parameters);
            return result;
        }
    }

    public async Task<bool> IsExistVisaTypeAsync(string visaType, int? id = null)
    {
        var query = @"SELECT COUNT(*) FROM VisaType WHERE VisaType=@VisaType";

        if (id != null)
        {
            query += " AND ID != @ID";
        }

        var parameters = new DynamicParameters();
        parameters.Add("VisaType", visaType, DbType.String);

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

    public async Task<int> CreateAsync(VisaType model)
    {
        var query = "INSERT INTO VisaType (VisaType) VALUES (@VisaType) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";

        var parameters = new DynamicParameters();
        parameters.Add("VisaType", model.VisaTypeName, DbType.String);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateAsync(int id, VisaType model)
    {
        var query = "UPDATE VisaType SET VisaType = @VisaType WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("VisaType", model.VisaTypeName, DbType.String);
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var query = "DELETE FROM VisaType WHERE ID = @ID";

        var parameters = new DynamicParameters();
        parameters.Add("ID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
}
