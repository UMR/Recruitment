using Recruitment.Domain.Entities;

namespace Recruitment.Application.Contracts.Persistence
{
    public interface IAgencyRepository
    {
        Task<IEnumerable<Agency>> GetAgencies();

        Task<Agency> GetAgencyById(long id);

        Task<int> CreateAgency(Agency agency);

        Task<bool> UpdateAgency(long id,Agency agency);

        Task<bool> DeleteAgency(long agency);
    }
}
