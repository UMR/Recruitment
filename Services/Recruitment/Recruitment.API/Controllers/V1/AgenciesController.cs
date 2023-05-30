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

        [HttpGet("GetAgencies", Name = "GetAgencies")]
        public async Task<ActionResult<List<AgencyListDto>>> GetAgencies()
        {
            return await _agencyService.GetAgencies();
        }

        [HttpGet("GetAgency/{id:int}", Name = "GetAgency")]
        public async Task<ActionResult<AgencyListDto>> GetAgency(int id)
        {
            return await _agencyService.GetAgencyById(id);
        }

        [HttpPost("CreateAgency")]
        public async Task<ActionResult> PostAsync([FromBody] CreateAgencyDto request)
        {
            var response = await _agencyService.CreateAgency(request);
            return Ok(response);
        }

        [HttpPut("UpdateAgency/{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateAgencyDto request)
        {
            var response = await _agencyService.UpdateAgency(id, request);
            return Ok(response);
        }

        [HttpDelete("DeleteAgency/{id}")]
        public void Delete(int id)
        {
        }
    }
}
