namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class CountriesController : ApiControllerBase
{
    private readonly ICountryService _countryService;

    public CountriesController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<PositionLicenseRequirementListDto>>> GetAllAsync()
    {
        return Ok(await _countryService.GetAllAsync());
    }

    [HttpGet("GetById/{id:int}")]
    public async Task<ActionResult<PositionLicenseRequirementListDto>> GetByIdAsync(int id)
    {
        return Ok(await _countryService.GetByIdAsync(id));
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostAsync([FromBody] CreateCountryDto request)
    {
        return Ok(await _countryService.CreateAsync(request));
    }

    [HttpPut("Update/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdateCountryDto request)
    {
        return Ok(await _countryService.UpdateAsync(id, request));
    }

    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        return Ok(await _countryService.DeleteAsync(id));
    }
}
