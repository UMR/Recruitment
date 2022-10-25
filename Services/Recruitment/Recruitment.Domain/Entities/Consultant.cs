using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Consultant
    {
        public int ConsultantId { get; set; }
        public int RecuriterId { get; set; }
        public int ApplicantId { get; set; }
        public int PositionId { get; set; }
        public int Month { get; set; }
        public DateTime StartDate { get; set; }
        public decimal MoneyDue { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Position Position { get; set; } = null!;
        public virtual Recruiter Recuriter { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
