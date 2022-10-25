using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InfluenzaVaccination
    {
        public long InfluenzaVaccinationId { get; set; }
        public string? FacilityName { get; set; }
        public string? ReasonDeclination { get; set; }
        public string? Signature { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public int ApplicantId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
