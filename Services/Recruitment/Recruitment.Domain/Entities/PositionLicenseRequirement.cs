using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class PositionLicenseRequirement
    {
        public PositionLicenseRequirement()
        {
            Positions = new HashSet<Position>();
            ProfilePositionLicenseRequirementMaps = new HashSet<ProfilePositionLicenseRequirementMap>();
        }

        public long PositionLicenseRequirementId { get; set; }
        public string PositionLicenseRequirementName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<ProfilePositionLicenseRequirementMap> ProfilePositionLicenseRequirementMaps { get; set; }
    }
}
