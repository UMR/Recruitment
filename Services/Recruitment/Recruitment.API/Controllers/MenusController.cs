using Microsoft.AspNetCore.Mvc;
using Recruitment.Application.Features.Menu.Queries;

namespace ResourceServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenusController : ApiControllerBase
    {
        [HttpGet(Name = "GetMenus")]
        public async Task<ActionResult<IEnumerable<MenuDto>>> GetMenus()
        {
            return await Mediator.Send(new GetMenusQuery());
        }

        [HttpGet("{id}", Name = "GetMenuById")]
        public async Task<ActionResult<MenuDto>> GetMenu(int id)
        {
            return await Mediator.Send(new GetMenuByIdQuery { Id = id });
        }
    }
}