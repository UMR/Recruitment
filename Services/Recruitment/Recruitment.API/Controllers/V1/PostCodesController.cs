namespace Recruitment.API.Controllers.V1;

[Route("api/v1/[controller]")]
[ApiController]
public class PostCodesController : ControllerBase
{
    private readonly IPostCodeService _postCodeService;

    public PostCodesController(IPostCodeService postCodeService)
    {
        _postCodeService = postCodeService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<PostCodeListDto>>> GetAllAsync()
    {
        return Ok(await _postCodeService.GetAllAsync());
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<ActionResult<PostCodeListDto>> GetByIdAsync(int id)
    {
        return Ok(await _postCodeService.GetByIdAsync(id));
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostAsync([FromBody] CreatePostCodeDto request)
    {
        return Ok(await _postCodeService.CreateAsync(request));
    }

    [HttpPut("Update/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdatePostCodeDto request)
    {
        return Ok(await _postCodeService.UpdateAsync(id, request));
    }

    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        return Ok(await _postCodeService.DeleteAsync(id));
    }
}
