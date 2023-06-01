using RefreshTokenRequest = Recruitment.IdentityServer.Models.RefreshTokenRequest;
using TokenRequest = Recruitment.IdentityServer.Models.TokenRequest;
using TokenResponse = Recruitment.IdentityServer.Models.TokenResponse;

namespace Recruitment.IdentityServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("Token")]
        public async Task<IActionResult> GetToken(TokenRequest request)
        {
            var tokenResponse = await _authenticationService.GetToken(request.Username, request.Password);

            if (!tokenResponse.IsError)
            {
                return Ok(JsonConvert.DeserializeObject<TokenResponse>(tokenResponse.Raw));
            }
            else
            {
                return Ok(tokenResponse);
            }
        }

        [HttpPost("RefreshToken")]
        public async Task<IActionResult> GetRefreshTokenByToken(RefreshTokenRequest request)
        {
            var tokenResponse = await _authenticationService.GetRefreshTokenByToken(request.RefreshToken);

            if (!tokenResponse.IsError)
            {
                return Ok(JsonConvert.DeserializeObject<TokenResponse>(tokenResponse.Raw));
            }
            else
            {
                return Ok(tokenResponse);
            }
        }
    }
}
