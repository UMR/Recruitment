namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class ManageRoleController : ApiControllerBase
{
    private readonly IEmailTypeService _emailTypeService;

    public ManageRoleController(IEmailTypeService emailTypeService)
    {
        _emailTypeService = emailTypeService;
    }

    [HttpGet("GetEmailTypes")]
    public async Task<ActionResult<List<EmailTypeListDto>>> GetEmailTypesAsync()
    {
        return Ok(await _emailTypeService.GetAllAsync());
    }

    [HttpGet("GetEmailType/{id:int}")]
    public async Task<ActionResult<EmailTypeListDto>> GetEmailTypeAsync(int id)
    {
        return Ok(await _emailTypeService.GetByIdAsync(id));
    }

    [HttpPost("CreateEmailType")]
    public async Task<ActionResult> PostAsync([FromBody] CreateEmailTypeDto request)
    {            
        return Ok(await _emailTypeService.CreateAsync(request));
    }

    [HttpPut("UpdateEmailType/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdateEmailTypeDto request)
    {            
        return Ok(await _emailTypeService.UpdateAsync(id, request));
    }    

    [HttpDelete("DeleteEmailType/{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {            
        return Ok(await _emailTypeService.DeleteAsync(id));
    }
}
