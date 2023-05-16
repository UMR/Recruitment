using Microsoft.AspNetCore.Mvc;

namespace Recruitment.IdentityServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {       

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to Recruitment Authentication Server");
        }
    }
}