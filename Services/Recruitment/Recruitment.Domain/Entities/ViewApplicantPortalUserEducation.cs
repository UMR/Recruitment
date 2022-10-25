using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ViewApplicantPortalUserEducation
    {
        public long UserEducationId { get; set; }
        public string SchoolName { get; set; } = null!;
        public string SchoolAddress { get; set; } = null!;
        public string Degree { get; set; } = null!;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsGraduate { get; set; }
        public long UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? InstitutionType { get; set; }
    }
}
