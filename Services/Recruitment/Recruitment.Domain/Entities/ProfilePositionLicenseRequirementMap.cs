using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ProfilePositionLicenseRequirementMap
    {
        public long ProfilePositionLicenseRequirementMapId { get; set; }
        public long PositionLicenseRequirementId { get; set; }
        public long ProfileTemplateMasterId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual PositionLicenseRequirement PositionLicenseRequirement { get; set; } = null!;
        public virtual ProfileTemplateMaster ProfileTemplateMaster { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
