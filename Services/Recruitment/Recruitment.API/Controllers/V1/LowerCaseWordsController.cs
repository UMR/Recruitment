namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class LowerCaseWordsController : ControllerBase
{
    private readonly ILowerCaseWordService _lowerCaseWordService;

    public LowerCaseWordsController(ILowerCaseWordService upperCaseWordService)
    {
        _lowerCaseWordService = upperCaseWordService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<LowerCaseWordListDto>>> GetAllAsync()
    {
        return Ok(await _lowerCaseWordService.GetAllAsync());
    }

    [HttpGet("GetById/{id:long}")]
    public async Task<ActionResult<LowerCaseWordListDto>> GetByIdAsync(long id)
    {
        return Ok(await _lowerCaseWordService.GetByIdAsync(id));
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostAsync([FromBody] CreateLowerCaseWordDto request)
    {
        return Ok(await _lowerCaseWordService.CreateAsync(request));
    }

    [HttpPut("Update/{id:long}")]
    public async Task<ActionResult> PutAsync(long id, [FromBody] UpdateLowerCaseWordDto request)
    {
        return Ok(await _lowerCaseWordService.UpdateAsync(id, request));
    }

    [HttpDelete("Delete/{id:long}")]
    public async Task<ActionResult> DeleteAsync(long id)
    {
        return Ok(await _lowerCaseWordService.DeleteAsync(id));
    }
}
