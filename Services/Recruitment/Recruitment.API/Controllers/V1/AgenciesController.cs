using Microsoft.AspNetCore.Mvc;
using Recruitment.Application.Features.Agencies.Dtos;
using Recruitment.Application.Features.Agencies.Services;

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

        [HttpPost]
        public async Task<int> PostAsync([FromBody] CreateAgencyDto request)
        {
            return await _agencyService.CreateAgency(request);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
