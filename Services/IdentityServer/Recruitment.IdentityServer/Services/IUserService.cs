using Recruitment.IdentityServer.Models;

namespace Recruitment.IdentityServer.Services
{
    public interface IUserService
    {
        Task<int> GetUserId(string loginId, string password);

        Task<User> GetUserById(int userId);

        Task<bool> IsActiveUser(int userId);
    }
}
