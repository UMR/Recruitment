namespace Recruitment.IdentityServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public AuthenticationController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            LoginResponse response;

            try
            {
                var identityServerResponse = await _httpClient.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = $"{this.Request.Scheme}://{this.Request.Host}/connect/token",
                    GrantType = "password",
                    ClientId = "recruitmentweb",
                    ClientSecret = "s*|9%2~*=95*+|t8*~3**%;U73*+-c",
                    Scope = "recruitment.fullaccess offline_access",
                    UserName = request.Username,
                    Password = request.Password
                });

                if (!identityServerResponse.IsError)
                {
                    response = JsonConvert.DeserializeObject<LoginResponse>(identityServerResponse.Raw);
                }
                else
                {
                    return Ok(identityServerResponse.ErrorDescription);
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

            return Ok(new { Token = response });
        }

        [HttpGet("Login/{username}/{password}")]
        public async Task<IActionResult> GetLogin(string username,string password)
        {
            LoginResponse response;

            try
            {
                var identityServerResponse = await _httpClient.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = $"{this.Request.Scheme}://{this.Request.Host}/connect/token",
                    GrantType = "password",
                    ClientId = "recruitmentweb",
                    ClientSecret = "s*|9%2~*=95*+|t8*~3**%;U73*+-c",
                    Scope = "recruitment.fullaccess offline_access",
                    UserName = username,
                    Password = password
                });

                if (!identityServerResponse.IsError)
                {
                    response = JsonConvert.DeserializeObject<LoginResponse>(identityServerResponse.Raw);
                }
                else
                {
                    return Ok(identityServerResponse.ErrorDescription);
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

            return Ok(new { Token = response });
        }
    }
}
