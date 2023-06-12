using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.Application.Contracts.Persistence
{
    public interface IUserRepository
    {
        Task<bool> UpdateUserByAgencyAsync(long id, UpdateAgencyStatusByUserDto agency);
        Task<bool> DeleteUserByAgencyAsync(long agency);
    }
}
