using Dapper;
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

        public async Task<Agency> GetAgencyById(int id)
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
    }
}
