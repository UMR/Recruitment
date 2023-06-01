using RefreshTokenRequest = Recruitment.IdentityServer.Models.RefreshTokenRequest;
using TokenRequest = Recruitment.IdentityServer.Models.TokenRequest;
using TokenResponse = Recruitment.IdentityServer.Models.TokenResponse;

namespace Recruitment.IdentityServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _address;

        public AuthenticationController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _address = _configuration.GetSection("IdentityServer")["IssuerUri"]; 
        }

        [HttpPost("Token")]
        public async Task<IActionResult> GetToken(TokenRequest request)
        {
            TokenResponse response;

            try
            {                
                var identityServerResponse = await _httpClient.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = $"{_address}/connect/token",
                    GrantType = "password",
                    ClientId = "recruitmentweb",
                    ClientSecret = "s*|9%2~*=95*+|t8*~3**%;U73*+-c",
                    Scope = "recruitment.fullaccess offline_access",
                    UserName = request.Username,
                    Password = request.Password
                });

                if (!identityServerResponse.IsError)
                {
                    response = JsonConvert.DeserializeObject<TokenResponse>(identityServerResponse.Raw);
                }
                else
                {
                    return Ok(identityServerResponse);
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

            return Ok(response);
        }

        [HttpPost("RefreshToken")]
        public async Task<IActionResult> GetRefreshTokenByToken(RefreshTokenRequest request)
        {
            TokenResponse response;

            try
            {                
                var identityServerResponse = await _httpClient.RequestRefreshTokenAsync(new IdentityModel.Client.RefreshTokenRequest
                {
                    Address = $"{_address}/connect/token",
                    GrantType = "refresh_token",
                    RefreshToken = request.RefreshToken,
                    ClientId = "recruitmentweb",
                    ClientSecret = "s*|9%2~*=95*+|t8*~3**%;U73*+-c"
                });

                if (!identityServerResponse.IsError)
                {
                    response = JsonConvert.DeserializeObject<TokenResponse>(identityServerResponse.Raw);
                }
                else
                {
                    return Ok(identityServerResponse);
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

            return Ok(response);
        }
    }
}
