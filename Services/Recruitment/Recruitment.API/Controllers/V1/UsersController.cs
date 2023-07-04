namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class UsersController : ApiControllerBase
{
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUserId")]
    public IActionResult Get()
    {
        return Ok(CurrentUser.UserId);
    }
    [HttpGet("GetUser")]
    public IActionResult GetUserInfo()
    {
        return Ok(CurrentUser);

    }
}