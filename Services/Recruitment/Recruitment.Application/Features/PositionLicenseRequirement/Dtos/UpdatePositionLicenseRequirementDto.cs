namespace Recruitment.Application.Features.PositionLicenseRequirement
{
    public class UpdatePositionLicenseRequirementDto
    {
        public long PositionLicenseRequirementId { get; set; }
        public string PositionLicenseRequirementName { get; set; } = null!;
    }
}
