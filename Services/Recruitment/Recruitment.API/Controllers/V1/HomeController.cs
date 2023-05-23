namespace Recruitment.API.Controllers.V1
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to Recruitment Resource Server");
        }
    }
}
