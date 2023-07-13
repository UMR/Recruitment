using Recruitment.Application.Features.ManageRole;

namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class RoleController : ApiControllerBase
{
    private readonly IRoleService _roleService;

    public RoleController(IRoleService roleService)
    {
        _roleService = roleService;
    }

    [HttpGet("GetRole")]
    public async Task<ActionResult<List<RoleListDto>>> GetRolesAsync()
    {
        return Ok(await _roleService.GetAllAsync());
    }

    [HttpGet("GetRoleBy/{id:int}")]
    public async Task<ActionResult<RoleListDto>> GetRoleAsync(int id)
    {
        return Ok(await _roleService.GetByIdAsync(id));
    }

    [HttpPost("CreateRole")]
    public async Task<ActionResult> PostAsync([FromBody] CreateRoleDto request)
    {            
        return Ok(await _roleService.CreateAsync(request));
    }

    [HttpPut("UpdateRole/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdateRoleDto request)
    {            
        return Ok(await _roleService.UpdateAsync(id, request));
    }    

    [HttpDelete("DeleteRole/{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {            
        return Ok(await _roleService.DeleteAsync(id));
    }

    [HttpGet("GetRoleByUser/{userId:int}")]
    public async Task<ActionResult<RoleListDto>> GetRoleByUserAsync(int userId)
    {
        return Ok(await _roleService.GetRoleByUserAsync(userId));
    }
}
