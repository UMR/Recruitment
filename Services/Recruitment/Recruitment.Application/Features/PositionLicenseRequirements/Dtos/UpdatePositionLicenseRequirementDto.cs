namespace Recruitment.Application.Features.PositionLicenseRequirements
{
    public class UpdatePositionLicenseRequirementDto
    {
        public long PositionLicenseRequirementId { get; set; }
        public string PositionLicenseRequirementName { get; set; } = null!;
    }
}
