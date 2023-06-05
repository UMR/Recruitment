namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class AgenciesController : ApiControllerBase
{
    private readonly IAgencyService _agencyService;

    public AgenciesController(IAgencyService agencyService)
    {
        _agencyService = agencyService;
    }

    [HttpGet("GetAgencies")]
    public async Task<ActionResult<List<AgencyListDto>>> GetAgenciesAsync()
    {
        return await _agencyService.GetAgenciesAsync();
    }

    [HttpGet("GetAgency/{id:int}")]
    public async Task<ActionResult<AgencyListDto>> GetAgencyAsync(int id)
    {
        return await _agencyService.GetAgencyByIdAsync(id);
    }

    [HttpPost("CreateAgency")]
    public async Task<ActionResult> PostAsync([FromBody] CreateAgencyDto request)
    {            
        return Ok(await _agencyService.CreateAgencyAsync(request));
    }

    [HttpPut("UpdateAgency/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdateAgencyDto request)
    {            
        return Ok(await _agencyService.UpdateAgencyAsync(id, request));
    }

    [HttpDelete("DeleteAgency/{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {            
        return Ok(await _agencyService.DeleteAgencyAsync(id));
    }
}
