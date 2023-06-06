using Recruitment.Application.Features.Menu.Dtos;
using Recruitment.Application.Features.Menu.Queries;

namespace Recruitment.API.Controllers.V1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MenusController : ApiControllerBase
    {
        [HttpGet(Name = "GetMenus")]
        public async Task<ActionResult<IEnumerable<MenuListDto>>> GetMenus()

        {
            return await Mediator.Send(new GetMenusQuery());
        }

        [HttpGet("{id}", Name = "GetMenuById")]
        public async Task<ActionResult<MenuListDto>> GetMenu(int id)
        {
            return await Mediator.Send(new GetMenuByIdQuery { Id = id });
        }
    }
}