namespace Recruitment.API.Controllers.V1;

[Route("api/v1/[controller]")]
[ApiController]
public class LanguagesController : ControllerBase
{
    private readonly ILanguageService _languageService;

    public LanguagesController(ILanguageService visaTypeService)
    {
        _languageService = visaTypeService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<LanguageListDto>>> GetAllAsync()
    {
        return Ok(await _languageService.GetAllAsync());
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<ActionResult<LanguageListDto>> GetByIdAsync(int id)
    {
        return Ok(await _languageService.GetByIdAsync(id));
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostAsync([FromBody] CreateLanguageDto request)
    {
        return Ok(await _languageService.CreateAsync(request));
    }

    [HttpPut("Update/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdateLanguageDto request)
    {
        return Ok(await _languageService.UpdateAsync(id, request));
    }

    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        return Ok(await _languageService.DeleteAsync(id));
    }
}
