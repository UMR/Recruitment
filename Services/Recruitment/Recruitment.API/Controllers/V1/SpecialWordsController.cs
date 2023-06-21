namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class SpecialWordsController : ApiControllerBase
{
    private readonly ISpecialWordService _specialWordService;

    public SpecialWordsController(ISpecialWordService specialWordService)
    {
        _specialWordService = specialWordService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<SpecialWordListDto>>> GetAllAsync()
    {
        return Ok(await _specialWordService.GetAllAsync());
    }

    [HttpGet("GetById/{id:long}")]
    public async Task<ActionResult<SpecialWordListDto>> GetByIdAsync(long id)
    {
        return Ok(await _specialWordService.GetByIdAsync(id));
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostAsync([FromBody] CreateSpecialWordDto request)
    {
        return Ok(await _specialWordService.CreateAsync(request));
    }

    [HttpPut("Update/{id:long}")]
    public async Task<ActionResult> PutAsync(long id, [FromBody] UpdateSpecialWordDto request)
    {
        return Ok(await _specialWordService.UpdateAsync(id, request));
    }

    [HttpDelete("Delete/{id:long}")]
    public async Task<ActionResult> DeleteAsync(long id)
    {
        return Ok(await _specialWordService.DeleteAsync(id));
    }
}
