using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantInstitutionStatus
    {
        public ApplicantInstitutionStatus()
        {
            Aiscontacts = new HashSet<Aiscontact>();
            ApplicantWorkHistories = new HashSet<ApplicantWorkHistory>();
            Interviews = new HashSet<Interview>();
            RecruitmentComments = new HashSet<RecruitmentComment>();
        }

        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int InstitutionId { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? Date { get; set; }
        public int? InstitutionContactId { get; set; }
        public double? TotalFee { get; set; }
        public double? NetFee { get; set; }
        public double? RefFee { get; set; }
        public int? PositionId { get; set; }
        public bool? IsActiveStatus { get; set; }
        public int? UserId { get; set; }
        public decimal? CurrentSalary { get; set; }
        public decimal? ExpectedSalary { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte? ProfileStatus { get; set; }
        public string? Shift { get; set; }
        public int? HireType { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Institute Institution { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Aiscontact> Aiscontacts { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistories { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
        public virtual ICollection<RecruitmentComment> RecruitmentComments { get; set; }
    }
}
