namespace Recruitment.Persistence.Repositories;

public class InstitutionRepository : IInstitutionRepository
{
    private readonly IDapperContext _dapperContext;

    public InstitutionRepository(IDapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }

    public async Task<bool> GetInstitutionByInstituteTypeIdAsync(int id)
    {
        var query = "UPDATE [InstituteType]  SET [InstituteType] = @InstituteType,[Description] = @Description ," +
             "[UpdatedBy] = @UpdatedBy ,[UpdatedDate] = @UpdatedDate WHERE InstituteTypeID = @InstituteTypeID";

        var parameters = new DynamicParameters();
        parameters.Add("InstituteTypeID", id, DbType.Int32);

        using (IDbConnection conn = _dapperContext.CreateConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }
}
