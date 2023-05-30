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

        [HttpGet(Name = "GetAgencies")]
        public async Task<ActionResult<List<AgencyListDto>>> GetAgencies()
        {
            return await _agencyService.GetAgencies();
        }

        [HttpGet("{id}", Name = "GetAgency")]
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

        [HttpPut("CreateAgency/{id}")]
        public void Put(int id, [FromBody] CreateAgencyDto request)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
