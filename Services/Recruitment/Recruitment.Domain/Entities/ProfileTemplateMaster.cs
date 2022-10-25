using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ProfileTemplateMaster
    {
        public ProfileTemplateMaster()
        {
            ApplicantProfiles = new HashSet<ApplicantProfile>();
            ApplicantTemplateMasterProfiles = new HashSet<ApplicantTemplateMasterProfile>();
            ProfilePositionLicenseRequirementMaps = new HashSet<ProfilePositionLicenseRequirementMap>();
            ProfilePositionMaps = new HashSet<ProfilePositionMap>();
            ProfileTemplateDetails = new HashSet<ProfileTemplateDetail>();
        }

        public long ProfileTemplateMasterId { get; set; }
        public string ProfileTemplateName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantProfile> ApplicantProfiles { get; set; }
        public virtual ICollection<ApplicantTemplateMasterProfile> ApplicantTemplateMasterProfiles { get; set; }
        public virtual ICollection<ProfilePositionLicenseRequirementMap> ProfilePositionLicenseRequirementMaps { get; set; }
        public virtual ICollection<ProfilePositionMap> ProfilePositionMaps { get; set; }
        public virtual ICollection<ProfileTemplateDetail> ProfileTemplateDetails { get; set; }
    }
}
