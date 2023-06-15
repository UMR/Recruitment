namespace Recruitment.Application.Features.InstitutionTypes;

public class UpdateInstitutionTypeDto
{
    public int InstituteTypeID { get; set; }
    public string InstituteType { get; set; } = null!;
    public string Description { get; set; }
}
