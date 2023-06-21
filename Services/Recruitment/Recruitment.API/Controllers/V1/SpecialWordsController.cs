namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class SpecialWordsController : ApiControllerBase
{
    private readonly IUpperCaseWordService _specialWordService;

    public SpecialWordsController(IUpperCaseWordService specialWordService)
    {
        _specialWordService = specialWordService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<UpperCaseWordListDto>>> GetAllAsync()
    {
        return Ok(await _specialWordService.GetAllAsync());
    }

    [HttpGet("GetById/{id:long}")]
    public async Task<ActionResult<UpperCaseWordListDto>> GetByIdAsync(long id)
    {
        return Ok(await _specialWordService.GetByIdAsync(id));
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostAsync([FromBody] CreateSpecialWordDto request)
    {
        return Ok(await _specialWordService.CreateAsync(request));
    }

    [HttpPut("Update/{id:long}")]
    public async Task<ActionResult> PutAsync(long id, [FromBody] UpdateUpperCaseWordDto request)
    {
        return Ok(await _specialWordService.UpdateAsync(id, request));
    }

    [HttpDelete("Delete/{id:long}")]
    public async Task<ActionResult> DeleteAsync(long id)
    {
        return Ok(await _specialWordService.DeleteAsync(id));
    }
}
