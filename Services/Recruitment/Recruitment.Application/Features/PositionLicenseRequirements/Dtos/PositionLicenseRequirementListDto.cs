namespace Recruitment.Application.Features.PositionLicenseRequirements
{
    public class PositionLicenseRequirementListDto
    {
        public long PositionLicenseRequirementId { get; set; }
        public string PositionLicenseRequirementName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
