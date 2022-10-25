using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class HepaBhippa
    {
        public long HepaBhippaid { get; set; }
        public bool HasHepaConcent { get; set; }
        public bool? HasHepaSheet { get; set; }
        public bool? HasHepaTraining { get; set; }
        public bool? IsExamined { get; set; }
        public bool? HasNoCostHepa { get; set; }
        public bool? HasFacilityInfo { get; set; }
        public string? Comment { get; set; }
        public DateTime? SignatureDate { get; set; }
        public string? WitnessName { get; set; }
        public DateTime? WitnessSignatureDate { get; set; }
        public string? ComplianceOfficer { get; set; }
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
