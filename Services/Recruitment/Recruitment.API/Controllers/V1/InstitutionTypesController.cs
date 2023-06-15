using Recruitment.Application.Features.InstitutionTypes;

namespace Recruitment.API.Controllers.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class InstitutionTypesController : ApiControllerBase
{
    private readonly IInstitutionTypeService _institutionTypeService;

    public InstitutionTypesController(IInstitutionTypeService institutionTypeService)
    {
        _institutionTypeService = institutionTypeService;
    }

    [HttpGet("GetInstitutionTypes")]
    public async Task<ActionResult<List<InstitutionTypeListDto>>> GetEmailTypesAsync()
    {
        return Ok(await _institutionTypeService.GetInstitutionTypesAsync());
    }

    [HttpGet("GetInstitutionType/{id:int}")]
    public async Task<ActionResult<InstitutionTypeListDto>> GetEmailTypeAsync(int id)
    {
        return Ok(await _institutionTypeService.GetInstitutionTypeByIdAsync(id));
    }

    [HttpPost("CreateInstitutionType")]
    public async Task<ActionResult> PostAsync([FromBody] CreateInstitutionTypeDto request)
    {            
        return Ok(await _institutionTypeService.CreateInstitutionTypeAsync(request));
    }

    [HttpPut("UpdateInstitutionType/{id:int}")]
    public async Task<ActionResult> PutAsync(int id, [FromBody] UpdateInstitutionTypeDto request)
    {            
        return Ok(await _institutionTypeService.UpdateInstitutionTypeAsync(id, request));
    }    

    [HttpDelete("DeleteInstitutionType/{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {            
        return Ok(await _institutionTypeService.DeleteInstitutionTypeAsync(id));
    }
}
