namespace Recruitment.Application.Features.InstitutionTypes;

public class InstitutionTypeListDto
{
    public int InstituteTypeId { get; set; }
    public string InstituteType { get; set; } = null!;
    public string? Description { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
