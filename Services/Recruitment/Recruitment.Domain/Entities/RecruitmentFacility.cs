using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class RecruitmentFacility
    {
        public int Id { get; set; }
        public int InstitutionId { get; set; }
        public int ApplicantId { get; set; }
        public int PositionId { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? Date { get; set; }
        public string? Notify { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Institute Institution { get; set; } = null!;
        public virtual Position Position { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
