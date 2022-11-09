using Dapper;
using Microsoft.EntityFrameworkCore;
using Recruitment.Application.Contracts.Persistence;
using Recruitment.Domain.Entities;
using Recruitment.Persistence.Common;
using System.Data;

namespace Recruitment.Persistence.Repositories
{
    internal class AgencyRepository : IAgencyRepository
    {
        private readonly IRecruitmentConnectionFactory _recruitmentConnectionFactory;

        public AgencyRepository(IRecruitmentConnectionFactory recruitmentConnectionFactory)
        {
            _recruitmentConnectionFactory = recruitmentConnectionFactory;
        }

        public async Task<IEnumerable<Agency>> GetAgencies()
        {
            var query = @"SELECT * FROM Agency ORDER BY AgencyName ASC";

            using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
            {
                var agencies = await conn.QueryAsync<Agency>(query);
                return agencies.ToList();
            }
        }

        public async Task<Agency> GetAgencyById(long id)
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

        public async Task<int> CreateAgency(Agency agency)
        {
            var query = "INSERT INTO Agency (AgencyName, CreatedBy, CreatedDate) VALUES (@AgencyName, @CreatedBy, @CreatedDate) SELECT CAST(SCOPE_IDENTITY() as int)";
            var parameters = new DynamicParameters();
            parameters.Add("AgencyName", agency.AgencyName, DbType.String);
            parameters.Add("CreatedBy", agency.CreatedBy, DbType.Int32);
            parameters.Add("CreatedDate", agency.CreatedDate, DbType.DateTime);

            using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
            {
                var id = await conn.ExecuteAsync(query, parameters);
                return id;
            }
        }        

        public async Task<bool> UpdateAgency(long id, Agency agency)
        {
            var query = "UPDATE Agency SET AgencyName = @AgencyName, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate WHERE AgencyID = @AgencyID";
            var parameters = new DynamicParameters();
            parameters.Add("AgencyID", id, DbType.Int64);
            parameters.Add("AgencyName", agency.AgencyName, DbType.String);
            parameters.Add("UpdatedBy", agency.UpdatedBy, DbType.Int32);
            parameters.Add("UpdatedDate", agency.UpdatedDate, DbType.DateTime);

            using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
            {
                var result = await conn.ExecuteAsync(query, parameters);
                return result > 0 ? true : false;
            }
        }

        public  async Task<bool> DeleteAgency(long id)
        {
            var query = "DELETE FROM Agency WHERE AgencyID = @AgencyID";
            var parameters = new DynamicParameters();
            parameters.Add("AgencyID", id, DbType.Int64);

            using (IDbConnection conn = _recruitmentConnectionFactory.GetConnection)
            {
                var result = await conn.ExecuteAsync(query);
                return result > 0 ? true : false;
            }
        }        
    }
}
