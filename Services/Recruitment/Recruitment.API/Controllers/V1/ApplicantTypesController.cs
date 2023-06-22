using Recruitment.Application.Features.ApplicantType;

namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class ApplicantTypesController : ApiControllerBase
{
    private readonly IApplicantTypeService _applicantTypeService;

    public ApplicantTypesController(IApplicantTypeService applicantTypeService)
    {
        _applicantTypeService = applicantTypeService;
    }

    [HttpGet("GetApplicantTypes")]
    public async Task<ActionResult<List<ApplicantTypeListDto>>> GetApplicantTypesAsync()
    {
        return Ok(await _applicantTypeService.GetAllAsync());
    }

    [HttpGet("GetApplicantType/{id:int}")]
    public async Task<ActionResult<ApplicantTypeListDto>> GetApplicantTypeAsync(int id)
    {
        return Ok(await _applicantTypeService.GetByIdAsync(id));
    }

    [HttpPost("CreateApplicantType")]
    public async Task<ActionResult> PostAsync([FromBody] CreateApplicantTypeDto request)
    {            
        return Ok(await _applicantTypeService.CreateAsync(request));
    }

    [HttpPut("UpdateApplicantType/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdateApplicantTypeDto request)
    {            
        return Ok(await _applicantTypeService.UpdateAsync(id, request));
    }    

    [HttpDelete("DeleteApplicantType/{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {            
        return Ok(await _applicantTypeService.DeleteAsync(id));
    }
}
