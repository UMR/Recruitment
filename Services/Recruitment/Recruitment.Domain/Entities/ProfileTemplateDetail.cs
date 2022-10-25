using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ProfileTemplateDetail
    {
        public ProfileTemplateDetail()
        {
            ApplicantProfiles = new HashSet<ApplicantProfile>();
            InverseOwner = new HashSet<ProfileTemplateDetail>();
        }

        public long ProfileTemplateDetailId { get; set; }
        public long ProfileTemplateMasterId { get; set; }
        public string NodeName { get; set; } = null!;
        public long? OwnerId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int ProfileDetailRank { get; set; }
        public int? RankNo { get; set; }
        public byte? FileType { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual ProfileTemplateDetail? Owner { get; set; }
        public virtual ProfileTemplateMaster ProfileTemplateMaster { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantProfile> ApplicantProfiles { get; set; }
        public virtual ICollection<ProfileTemplateDetail> InverseOwner { get; set; }
    }
}
