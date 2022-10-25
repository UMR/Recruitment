using Recruitment.Domain.Entities;

namespace Recruitment.Application.Contracts.Persistence
{
    public interface IAgencyRepository
    {
        Task<IEnumerable<Agency>> GetAgencies();
        Task<Agency> GetAgencyById(int id);
    }
}
