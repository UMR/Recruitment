using Microsoft.IdentityModel.Tokens;

namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class MenusController : ApiControllerBase
{
    private readonly IMenuService _menuService;
    public MenusController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    [HttpGet("GetMenus")]
    public async Task<ActionResult<IEnumerable<MenuListDto>>> GetMenus()
    {
        return Ok(await _menuService.GetMenusAsync());
    }

    [HttpGet("GetMenu/{id}")]
    public async Task<ActionResult<MenuListDto>> GetMenu(int id)
    {
        return Ok(await _menuService.GetMenuByIdAsync(id));
    }
}