namespace Recruitment.Application.Contracts.Persistence
{
    public interface IUserRepository
    {
        Task<bool> UpdateUserByAgencyAsync(long id, UpdateAgencyStatusByUserDto agency);
        Task<bool> DeleteUserByAgencyAsync(long agency);
        Task<List<ActiveUsersDtos>> GetActiveUsers();
    }
}
