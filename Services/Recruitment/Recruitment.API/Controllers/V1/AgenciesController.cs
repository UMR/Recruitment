namespace Recruitment.API.Controllers.V1
{
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
        public async Task<ActionResult<List<AgencyListDto>>> GetAgencies()
        {
            return await _agencyService.GetAgencies();
        }

        [HttpGet("GetAgency/{id:int}")]
        public async Task<ActionResult<AgencyListDto>> GetAgency(int id)
        {
            return await _agencyService.GetAgencyById(id);
        }

        [HttpPost("CreateAgency")]
        public async Task<ActionResult> PostAsync([FromBody] CreateAgencyDto request)
        {            
            return Ok(await _agencyService.CreateAgency(request));
        }

        [HttpPut("UpdateAgency/{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateAgencyDto request)
        {            
            return Ok(await _agencyService.UpdateAgency(id, request));
        }

        [HttpDelete("DeleteAgency/{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {            
            return Ok(await _agencyService.DeleteAgency(id));
        }
    }
}
