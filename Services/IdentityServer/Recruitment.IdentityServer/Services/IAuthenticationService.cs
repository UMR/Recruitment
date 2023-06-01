using TokenResponse = IdentityModel.Client.TokenResponse;

namespace Recruitment.IdentityServer.Services
{
    public interface IAuthenticationService
    {
        Task<TokenResponse> GetRefreshTokenByToken(string refreshToken);
        Task<TokenResponse> GetToken(string username, string password);
    }
}