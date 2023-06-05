namespace Recruitment.API.Controllers.V1;

[AllowAnonymous]
[ApiController]
[Route("api/v1/[controller]")]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    [AllowAnonymous]
    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogError("Hello");
        return Ok($"Welcome to Recruitment {Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")} Resource Server");
    }
}
