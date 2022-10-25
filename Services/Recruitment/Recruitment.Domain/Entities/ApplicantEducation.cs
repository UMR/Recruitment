using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantEducation
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string School { get; set; } = null!;
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? DegreeId { get; set; }
        public string Major { get; set; } = null!;
        public string? CurrentStatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? SchoolAddress { get; set; }
        public long? UserEducationId { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Degree? Degree { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
