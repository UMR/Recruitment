using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class RecruitmentComment
    {
        public RecruitmentComment()
        {
            ApplicantComments = new HashSet<ApplicantComment>();
            FollowUps = new HashSet<FollowUp>();
        }

        public long CommnetId { get; set; }
        public int? ApplicantId { get; set; }
        public int? InstituteId { get; set; }
        public int? UserId { get; set; }
        public short? ApplicantStatus { get; set; }
        public short? InstituteStatus { get; set; }
        public short? CommentType { get; set; }
        public short? CommentColumnType { get; set; }
        public string? Description { get; set; }
        public bool IsActiveStatus { get; set; }
        public int? PositionId { get; set; }
        public DateTime? CommentDate { get; set; }
        public int? ApplicantInstitutionStatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant? Applicant { get; set; }
        public virtual ApplicantInstitutionStatus? ApplicantInstitutionStatus { get; set; }
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Institute? Institute { get; set; }
        public virtual Position? Position { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<ApplicantComment> ApplicantComments { get; set; }
        public virtual ICollection<FollowUp> FollowUps { get; set; }
    }
}
