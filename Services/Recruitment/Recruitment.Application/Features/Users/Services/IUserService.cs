
namespace Recruitment.Application.Features.Users
{
    public interface IUserService
    {
        Task<List<ActiveUsersDtos>> GetActiveUserAsync();
    }
}
