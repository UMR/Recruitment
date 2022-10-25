using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ViewApplicantPortalHepaBhippa
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
        public long UserId { get; set; }
    }
}
