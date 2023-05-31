namespace Recruitment.IdentityServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public AuthenticationController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            LoginResponse response = new LoginResponse();

            try
            {
                var address = _configuration.GetSection("IdentityServer")["IssuerUri"];
                var identityServerResponse = await _httpClient.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    //Address = $"{Request.Scheme}://{Request.Host}/connect/token",
                    Address = $"{address}/connect/token",
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
    }
}
