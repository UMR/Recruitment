namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class UpperCaseWordsController : ApiControllerBase
{
    private readonly IUpperCaseWordService _upperCaseWordService;

    public UpperCaseWordsController(IUpperCaseWordService upperCaseWordService)
    {
        _upperCaseWordService = upperCaseWordService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<UpperCaseWordListDto>>> GetAllAsync()
    {
        return Ok(await _upperCaseWordService.GetAllAsync());
    }

    [HttpGet("GetById/{id:long}")]
    public async Task<ActionResult<UpperCaseWordListDto>> GetByIdAsync(long id)
    {
        return Ok(await _upperCaseWordService.GetByIdAsync(id));
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostAsync([FromBody] CreateUpperCaseWordDto request)
    {
        return Ok(await _upperCaseWordService.CreateAsync(request));
    }

    [HttpPut("Update/{id:long}")]
    public async Task<ActionResult> PutAsync(long id, [FromBody] UpdateUpperCaseWordDto request)
    {
        return Ok(await _upperCaseWordService.UpdateAsync(id, request));
    }

    [HttpDelete("Delete/{id:long}")]
    public async Task<ActionResult> DeleteAsync(long id)
    {
        return Ok(await _upperCaseWordService.DeleteAsync(id));
    }
}
