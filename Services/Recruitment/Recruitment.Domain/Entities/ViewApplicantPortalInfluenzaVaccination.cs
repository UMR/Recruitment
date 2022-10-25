using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ViewApplicantPortalInfluenzaVaccination
    {
        public long InfluenzaVaccinationId { get; set; }
        public string? FacilityName { get; set; }
        public string? ReasonDeclination { get; set; }
        public string? Signature { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public long UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
