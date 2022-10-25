using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class FollowUp
    {
        public int FollowUpId { get; set; }
        public long? CommnetId { get; set; }
        public int ApplicantId { get; set; }
        public int UserId { get; set; }
        public DateTime ActivateDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ViewDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual RecruitmentComment? Commnet { get; set; }
        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
