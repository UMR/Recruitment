namespace Recruitment.Domain.Entities
{
    public partial class PositionLicenseRequirement
    {
        public long PositionLicenseRequirementId { get; set; }
        public string PositionLicenseRequirementName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
