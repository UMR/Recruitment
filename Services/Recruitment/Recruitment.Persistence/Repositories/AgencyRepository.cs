namespace Recruitment.Persistence.Repositories;

internal class AgencyRepository : IAgencyRepository
{
    private readonly IRecruitmentConnectionFactory _recruitmentConnectionFactory;

    public AgencyRepository(IRecruitmentConnectionFactory recruitmentConnectionFactory)
    {
        _recruitmentConnectionFactory = recruitmentConnectionFactory;
    }

    public async Task<IEnumerable<Agency>> GetAgenciesAsync()
    {
        var query = @"SELECT * FROM Agency ORDER BY AgencyName ASC";

        using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
        {
            var agencies = await conn.QueryAsync<Agency>(query);
            return agencies.ToList();
        }
    }

    public async Task<Agency> GetAgencyByIdAsync(long id)
    {
        var query = @"SELECT * FROM Agency WHERE AgencyID=@AgencyID";

        var parameters = new DynamicParameters();
        parameters.Add("AgencyID", id, DbType.Int32);

        using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
        {
            var agency = await conn.QueryFirstOrDefaultAsync<Agency>(query, parameters);
            return agency;
        }
    }

    public async Task<int> CreateAgencyAsync(Agency agency)
    {
        var query = "INSERT INTO Agency (AgencyName, AgencyAddress, URLPrefix, AgencyEmail, AgencyPhone, AgencyContactPerson, AgencyContactPersonPhone, IsActive, AgencyLoginId, CreatedBy, CreatedDate) " +
                    "VALUES (@AgencyName, @AgencyAddress, @URLPrefix, @AgencyEmail, @AgencyPhone, @AgencyContactPerson, @AgencyContactPersonPhone, @IsActive, @AgencyLoginId, @CreatedBy, @CreatedDate) " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";
        var parameters = new DynamicParameters();
        parameters.Add("AgencyName", agency.AgencyName, DbType.String);
        parameters.Add("AgencyAddress", agency.AgencyAddress, DbType.String);
        parameters.Add("URLPrefix", agency.URLPrefix, DbType.String);
        parameters.Add("AgencyEmail", agency.AgencyEmail, DbType.String);
        parameters.Add("AgencyPhone", agency.AgencyPhone, DbType.String);
        parameters.Add("AgencyContactPerson", agency.AgencyContactPerson, DbType.String);
        parameters.Add("AgencyContactPersonPhone", agency.AgencyContactPersonPhone, DbType.String);
        parameters.Add("IsActive", agency.IsActive, DbType.Boolean);
        parameters.Add("AgencyLoginId", agency.AgencyLoginId, DbType.String);
        parameters.Add("CreatedBy", agency.CreatedBy, DbType.Int32);
        parameters.Add("CreatedDate", agency.CreatedDate, DbType.DateTime);

        using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
        {
            var id = await conn.ExecuteAsync(query, parameters);
            return id;
        }
    }        

    public async Task<bool> UpdateAgencyAsync(long id, Agency agency)
    {
        var query = "UPDATE Agency SET AgencyName = @AgencyName, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate WHERE AgencyID = @AgencyID";
        var parameters = new DynamicParameters();
        parameters.Add("AgencyID", id, DbType.Int64);
        parameters.Add("AgencyName", agency.AgencyName, DbType.String);
        parameters.Add("AgencyAddress", agency.AgencyAddress, DbType.String);
        parameters.Add("URLPrefix", agency.URLPrefix, DbType.String);
        parameters.Add("AgencyEmail", agency.AgencyEmail, DbType.String);
        parameters.Add("AgencyPhone", agency.AgencyPhone, DbType.String);
        parameters.Add("AgencyContactPerson", agency.AgencyContactPerson, DbType.String);
        parameters.Add("AgencyContactPersonPhone", agency.AgencyContactPersonPhone, DbType.String);
        parameters.Add("IsActive", agency.IsActive, DbType.Boolean);
        parameters.Add("AgencyLoginId", agency.AgencyLoginId, DbType.String);
        parameters.Add("UpdatedBy", agency.UpdatedBy, DbType.Int32);
        parameters.Add("UpdatedDate", agency.UpdatedDate, DbType.DateTime);

        using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }

    public  async Task<bool> DeleteAgencyAsync(long id)
    {
        var query = "DELETE FROM Agency WHERE AgencyID = @AgencyID";
        var parameters = new DynamicParameters();
        parameters.Add("AgencyID", id, DbType.Int64);

        using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
        {
            var result = await conn.ExecuteAsync(query, parameters);
            return result > 0 ? true : false;
        }
    }        
}
