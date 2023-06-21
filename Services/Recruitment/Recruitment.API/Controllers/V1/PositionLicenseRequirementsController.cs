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

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<PositionLicenseRequirementListDto>>> GetPositionLicenseRequirementsAsync()
    {
        return Ok(await _positionLicenseRequirementService.GetAllAsync());
    }

    [HttpGet("GetById/{id:long}")]
    public async Task<ActionResult<PositionLicenseRequirementListDto>> GetPositionLicenseRequirementAsync(long id)
    {
        return Ok(await _positionLicenseRequirementService.GetByIdAsync(id));
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostAsync([FromBody] CreatePositionLicenseRequirementDto request)
    {
        return Ok(await _positionLicenseRequirementService.CreateAsync(request));
    }

    [HttpPut("Update/{id:long}")]
    public async Task<ActionResult> PutAsync(long id, [FromBody] UpdatePositionLicenseRequirementDto request)
    {
        return Ok(await _positionLicenseRequirementService.UpdateAsync(id, request));
    }

    [HttpDelete("Delete/{id:long}")]
    public async Task<ActionResult> DeleteAsync(long id)
    {
        return Ok(await _positionLicenseRequirementService.DeleteAsync(id));
    }
}
