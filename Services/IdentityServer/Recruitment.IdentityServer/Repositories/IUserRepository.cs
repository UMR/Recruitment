namespace Recruitment.IdentityServer.Repositories
{
    public interface IUserRepository
    {
        Task<int> GetUserId(string loginId, string password);

        Task<DataTable> GetUserById(int userId);

        Task<bool> IsActiveUser(int userId);
    }
}
