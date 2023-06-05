namespace Recruitment.API.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public int? UserId {
        get 
        {
            int? userId = null;
            User currentUser = null;

            var currentUserClaim = _httpContextAccessor.HttpContext?.User?.FindFirst("user");

            if (currentUserClaim != null && !string.IsNullOrEmpty(currentUserClaim.Value))
            {
                currentUser = JsonConvert.DeserializeObject<User>(currentUserClaim.Value);
            }

            if (currentUser != null)
            {
                userId = currentUser.UserId;
            }

            return userId;
        }
    }
}
