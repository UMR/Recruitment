using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Aiscontact
    {
        public int Id { get; set; }
        public int Aisid { get; set; }
        public int ApplicantId { get; set; }
        public int InstitutionId { get; set; }
        public int InstitutionContactId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ApplicantInstitutionStatus Ais { get; set; } = null!;
        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Institute Institution { get; set; } = null!;
        public virtual Contact InstitutionContact { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
