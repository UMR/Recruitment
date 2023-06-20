using Recruitment.Application.Features.PositionLicenseRequirements;

namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class PositionLicenseRequirementsController : ApiControllerBase
{
    private readonly IPositionLicenseRequirementService _positionLicenseRequirementService;

    public PositionLicenseRequirementsController(IPositionLicenseRequirementService positionLicenseRequirementService)
    {
        _positionLicenseRequirementService = positionLicenseRequirementService;
    }

    [HttpGet("GetPositionLicenseRequirements")]
    public async Task<ActionResult<List<PositionLicenseRequirementListDto>>> GetPositionLicenseRequirementsAsync()
    {
        return Ok(await _positionLicenseRequirementService.GetAllAsync());
    }

    [HttpGet("GetPositionLicenseRequirementById/{id:long}")]
    public async Task<ActionResult<PositionLicenseRequirementListDto>> GetPositionLicenseRequirementAsync(long id)
    {
        return Ok(await _positionLicenseRequirementService.GetByIdAsync(id));
    }

    [HttpPost("CreatePositionLicenseRequirement")]
    public async Task<ActionResult> PostAsync([FromBody] CreatePositionLicenseRequirementDto request)
    {
        return Ok(await _positionLicenseRequirementService.CreateAsync(request));
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
