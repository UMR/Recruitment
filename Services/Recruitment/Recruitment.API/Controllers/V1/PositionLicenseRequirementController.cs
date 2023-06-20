using Recruitment.Application.Features.PositionLicenseRequirement;

namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class PositionLicenseRequirementController : ApiControllerBase
{
    private readonly IPositionLicenseRequirementService _positionLicenseRequirementService;

    public PositionLicenseRequirementController(IPositionLicenseRequirementService positionLicenseRequirementService)
    {
        _positionLicenseRequirementService = positionLicenseRequirementService;
    }

    [HttpGet("GetPositionLicenseRequirements")]
    public async Task<ActionResult<List<PositionLicenseRequirementListDto>>> GetEmailTypesAsync()
    {
        return Ok(await _positionLicenseRequirementService.GetPositionLicenseRequirementsAsync());
    }

    [HttpGet("GetPositionLicenseRequirementById/{id:long}")]
    public async Task<ActionResult<PositionLicenseRequirementListDto>> GetEmailTypeAsync(long id)
    {
        return Ok(await _positionLicenseRequirementService.GetPositionLicenseRequirementByIdAsync(id));
    }

    [HttpPost("CreatePositionLicenseRequirement")]
    public async Task<ActionResult> PostAsync([FromBody] CreatePositionLicenseRequirementDto request)
    {
        return Ok(await _positionLicenseRequirementService.CreatePositionLicenseRequirementAsync(request));
    }

    [HttpPut("UpdatePositionLicenseRequirement/{id:long}")]
    public async Task<ActionResult> PutAsync(long id, [FromBody] UpdatePositionLicenseRequirementDto request)
    {
        return Ok(await _positionLicenseRequirementService.UpdatePositionLicenseRequirementAsync(id, request));
    }

    [HttpDelete("DeletePositionLicenseRequirement/{id:long}")]
    public async Task<ActionResult> DeleteAsync(long id)
    {
        return Ok(await _positionLicenseRequirementService.DeletePositionLicenseRequirementAsync(id));
    }
}
