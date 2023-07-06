using Recruitment.Application.Features.ManageRecruiter;

namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class RecruiterController : ApiControllerBase
{
    private readonly IRecruiterService _recruiterService;

    public RecruiterController(IRecruiterService recruiterService)
    {
        _recruiterService = recruiterService;
    }

    [HttpGet("GetRecruiters")]
    public async Task<ActionResult<List<RecruiterListDto>>> GetAllRecruitersAsync()
    {
        return Ok(await _recruiterService.GetAllRecruitersAsync());
    }

    [HttpPost("GetRecruitersBy")]
    public async Task<ActionResult<List<RecruiterListDto>>> GetAllRecruitersByAsync([FromBody]SearchRecruiterParamDto request)
    {
        return Ok(await _recruiterService.GetAllRecruitersByAsync(request));
    }

    [HttpGet("GetRecruiter/{id:int}")]
    public async Task<ActionResult<RecruiterListDto>> GetRecruiterAsync(int id)
    {
        return Ok(await _recruiterService.GetRecruiterByIdAsync(id));
    }

    [HttpPost("CreateRecruiter")]
    public async Task<ActionResult> PostAsync([FromBody] CreateRecruiterDto request)
    {
        return Ok(await _recruiterService.CreateRecruiterAsync(request));
    }

    [HttpPut("UpdateRecruiter/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdateRecruiterDto request)
    {
        return Ok(await _recruiterService.UpdateRecruiterAsync(id, request));
    }

    [HttpDelete("DeleteRecruiter/{deleteUserId:int}/{updatedUserId:int}")]
    public async Task<ActionResult> DeleteAsync(int deleteUserId, int updatedUserId)
    {
        return Ok(await _recruiterService.DeleteRecruiterAsync(deleteUserId, updatedUserId));
    }
}
