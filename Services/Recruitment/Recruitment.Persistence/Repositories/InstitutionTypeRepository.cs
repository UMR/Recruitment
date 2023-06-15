namespace Recruitment.Persistence.Repositories;

public class InstitutionTypeRepository : IInstitutionTypeRepository
{
    private readonly IDapperContext _dapperContext;

    public InstitutionTypeRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    } 

    public async Task<IEnumerable<InstituteTypeTable>> GetInstitutionTypesAsync()
    {
        var query = @"SELECT * FROM [InstituteType] order by [Description]";

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var instituteTypes = await conn.QueryAsync<InstituteTypeTable>(query);
            return instituteTypes.ToList();
        }
    }

    public async Task<InstituteTypeTable> GetInstitutionTypeByIdAsync(int id)
    {
        var query = @"SELECT [InstituteTypeID],[InstituteType],[Description] FROM [InstituteType]
                            Where [InstituteTypeID]=@InstituteTypeID";

        var parameters = new DynamicParameters();
        parameters.Add("InstituteTypeID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var instituteType = await conn.QueryFirstOrDefaultAsync<InstituteTypeTable>(query, parameters);
            return instituteType;
        }
    }

    public async Task<int> CreateInstitutionTypeAsync(InstituteTypeTable instituteType)
    {
        var query = "INSERT INTO [InstituteType]([InstituteType],[Description],[CreatedBy],[CreatedDate]) VALUES(@InstituteType, @Description, @CreatedBy, @CreatedDate)";

        var parameters = new DynamicParameters();
        parameters.Add("InstituteType", instituteType.InstituteType, DbType.String);
        parameters.Add("Description", instituteType.Description, DbType.Boolean);
        parameters.Add("CreatedBy", instituteType.CreatedBy, DbType.Int32);
        parameters.Add("CreatedDate", instituteType.CreatedDate, DbType.DateTime);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }

    public async Task<bool> UpdateInstitutionTypeAsync(int id, InstituteTypeTable instituteType)
    {
        var query = "UPDATE [InstituteType]  SET [InstituteType] = @InstituteType,[Description] = @Description ," +
            "[UpdatedBy] = @UpdatedBy ,[UpdatedDate] = @UpdatedDate WHERE InstituteTypeID = @InstituteTypeID";

        var parameters = new DynamicParameters();
        parameters.Add("InstituteType", instituteType.InstituteType, DbType.String);
        parameters.Add("Description", instituteType.Description, DbType.Boolean);
        parameters.Add("UpdatedBy", instituteType.UpdatedBy, DbType.Int32);
        parameters.Add("UpdatedDate", instituteType.UpdatedDate, DbType.DateTime);
        parameters.Add("InstituteTypeID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public async Task<bool> DeleteInstitutionTypeAsync(long id)
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
