using Microsoft.AspNetCore.Mvc;
using Recruitment.Application.Features.Agency.Commands.CreateAgency;
using Recruitment.Application.Features.Agency.Queries;
using Recruitment.Application.Features.Menu.Queries;
using ResourceServer.Controllers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Recruitment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenciesController : ApiControllerBase
    {
        [HttpGet(Name = "GetAgencies")]
        public async Task<ActionResult<IEnumerable<AgencyDto>>> GetAgencies()
        {
            return await Mediator.Send(new GetAgenciesQuery());            
        }

        [HttpGet("{id}", Name = "GetAgency")]
        public async Task<ActionResult<AgencyDto>> GetAgency(int id)
        {
            return await Mediator.Send(new GetAgencyByIdQuery { Id = id });
        }

        [HttpPost]
        public async Task<int> PostAsync([FromBody] CreateAgencyCommand command)
        {
            return await Mediator.Send(command);
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
