namespace Recruitment.Persistence.Repositories
{
    public class PositionLicenseRequirementRepository : IPositionLicenseRequirementRepository
    {
        private readonly IDapperContext _dapperContext;

        public PositionLicenseRequirementRepository(IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<IEnumerable<PositionLicenseRequirement>> GetAllAsync()
        {
            var query = @"SELECT * FROM PositionLicenseRequirement ORDER BY PositionLicenseRequirementName ASC";

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var result = await conn.QueryAsync<PositionLicenseRequirement>(query);
                return result.ToList();
            }
        }

        public async Task<PositionLicenseRequirement> GetByIdAsync(long id)
        {
            var query = @"SELECT * FROM PositionLicenseRequirement WHERE PositionLicenseRequirementID=@PositionLicenseRequirementID";

            var parameters = new DynamicParameters();
            parameters.Add("PositionLicenseRequirementID", id, DbType.Int64);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var result = await conn.QueryFirstOrDefaultAsync<PositionLicenseRequirement>(query, parameters);
                return result;
            }
        }

        public async Task<bool> IsExistNameAsync(string name, long? id = null)
        {
            var query = @"SELECT COUNT(*) FROM PositionLicenseRequirement WHERE PositionLicenseRequirementName=@PositionLicenseRequirementName";

            if (id != null)
            {
                query += " AND PositionLicenseRequirementID != @PositionLicenseRequirementID";                
            }

            var parameters = new DynamicParameters();
            parameters.Add("PositionLicenseRequirementName", name, DbType.String);

            if (id is not null)
            {
                parameters.Add("PositionLicenseRequirementID", id, DbType.Int64);
            }

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var result = await conn.ExecuteScalarAsync<int>(query, parameters);
                return result > 0 ? true : false;
            }
        }

        public async Task<int> CreateAsync(PositionLicenseRequirement model)
        {
            var query = "INSERT INTO PositionLicenseRequirement (PositionLicenseRequirementName, CreatedBy, CreatedDate) VALUES (@PositionLicenseRequirementName, @CreatedBy, @CreatedDate) " +
                        "SELECT CAST(SCOPE_IDENTITY() as int)";

            var parameters = new DynamicParameters();
            parameters.Add("PositionLicenseRequirementName", model.PositionLicenseRequirementName, DbType.String);            
            parameters.Add("CreatedBy", model.CreatedBy, DbType.Int32);
            parameters.Add("CreatedDate", model.CreatedDate, DbType.DateTime);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var id = await conn.ExecuteAsync(query, parameters);
                return id;
            }
        }

        public async Task<bool> UpdateAsync(long id, PositionLicenseRequirement model)
        {
            var query = "UPDATE PositionLicenseRequirement SET PositionLicenseRequirementName = @PositionLicenseRequirementName, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate " +
                "WHERE PositionLicenseRequirementID = @PositionLicenseRequirementID";

            var parameters = new DynamicParameters();
            parameters.Add("PositionLicenseRequirementName", model.PositionLicenseRequirementName, DbType.String);
            parameters.Add("UpdatedBy", model.UpdatedBy, DbType.Int32);
            parameters.Add("UpdatedDate", model.UpdatedDate, DbType.DateTime);
            parameters.Add("PositionLicenseRequirementID", id, DbType.Int64);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var result = await conn.ExecuteAsync(query, parameters);
                return result > 0 ? true : false;
            }
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var query = "DELETE FROM PositionLicenseRequirement WHERE PositionLicenseRequirementID = @PositionLicenseRequirementID";

            var parameters = new DynamicParameters();
            parameters.Add("PositionLicenseRequirementID", id, DbType.Int64);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var result = await conn.ExecuteAsync(query, parameters);
                return result > 0 ? true : false;
            }
        }        
    }
}
