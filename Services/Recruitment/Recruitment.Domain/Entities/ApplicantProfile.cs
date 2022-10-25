using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantProfile
    {
        public long ApplicantProfileId { get; set; }
        public long ProfileTemplateDetailId { get; set; }
        public long ProfileTemplateMasterId { get; set; }
        public int? ApploicantAttachmentId { get; set; }
        public int? ApplicantCertificationId { get; set; }
        public int ApplicantId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual ApplicantCertification? ApplicantCertification { get; set; }
        public virtual ApplicantAttachment? ApploicantAttachment { get; set; }
        public virtual User? CreatedByNavigation { get; set; }
        public virtual ProfileTemplateDetail ProfileTemplateDetail { get; set; } = null!;
        public virtual ProfileTemplateMaster ProfileTemplateMaster { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
