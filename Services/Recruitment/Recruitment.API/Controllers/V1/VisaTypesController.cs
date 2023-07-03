namespace Recruitment.API.Controllers.V1;

[Route("api/[controller]")]
[ApiController]
public class VisaTypesController : ControllerBase
{
    private readonly IVisaTypeService _visaTypeService;

    public VisaTypesController(IVisaTypeService visaTypeService)
    {
        _visaTypeService = visaTypeService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<VisaTypeListDto>>> GetAllAsync()
    {
        return Ok(await _visaTypeService.GetAllAsync());
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<ActionResult<VisaTypeListDto>> GetByIdAsync(int id)
    {
        return Ok(await _visaTypeService.GetByIdAsync(id));
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostAsync([FromBody] CreateVisaTypeDto request)
    {
        return Ok(await _visaTypeService.CreateAsync(request));
    }

    [HttpPut("Update/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdateVisaTypeDto request)
    {
        return Ok(await _visaTypeService.UpdateAsync(id, request));
    }

    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        return Ok(await _visaTypeService.DeleteAsync(id));
    }
}
