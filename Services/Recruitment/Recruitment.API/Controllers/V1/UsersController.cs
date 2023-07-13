namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class UsersController : ApiControllerBase
{
    private readonly ILogger<UsersController> _logger;
    private readonly IUserService _userService;

    public UsersController(ILogger<UsersController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
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

    [HttpGet("GetActiveUser")]
    public async Task<ActionResult<List<ActiveUsersDtos>>> GetActiveUsers()
    {
        return await _userService.GetActiveUserAsync();
    }
}