using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment.Application.Features.Agencies;

namespace Recruitment.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDapperContext _dapperContext;

        public UserRepository(IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }
        public async Task<bool> DeleteUserByAgencyAsync(long agencyId)
        {
            var query = "DELETE [Users] WHERE [AgencyID]=@AgencyID";

            var parameters = new DynamicParameters();
            parameters.Add("AgencyID", agencyId, DbType.Int64);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var result = await conn.ExecuteAsync(query, parameters);
                return result > 0 ? true : false;
            }
        }

        public async Task<bool> UpdateUserByAgencyAsync(long id, UpdateAgencyStatusByUserDto agency)
        {
            var query =  "UPDATE [Users] SET [IsActive] = @IsActive,[UpdatedBy] = @UpdatedBy,[UpdatedDate] = @UpdatedDate WHERE [AgencyID] = @AgencyID";

            var parameters = new DynamicParameters();
            parameters.Add("IsActive", agency.IsActive, DbType.Boolean);
            parameters.Add("UpdatedBy", agency.UpdatedBy, DbType.Int32);
            parameters.Add("UpdatedDate", agency.UpdatedDate, DbType.DateTime);
            parameters.Add("AgencyID", id, DbType.Int64);

            using (IDbConnection conn = _dapperContext.CreateConnection)
            {
                var result = await conn.ExecuteAsync(query, parameters);
                return result > 0 ? true : false;
            }
        }
    }
}
