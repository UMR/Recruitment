using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantComment
    {
        public int CommentId { get; set; }
        public int ApplicantId { get; set; }
        public string? Comment { get; set; }
        public int UserId { get; set; }
        public DateTime CommentDate { get; set; }
        public long? RecruitmentCommentsId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual RecruitmentComment? RecruitmentComments { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
