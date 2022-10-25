using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ImportedApplicantPortalExperience
    {
        public long UserCompanyId { get; set; }
        public string CompanyName { get; set; } = null!;
        public long? EminstituteId { get; set; }
        public string? CompanyAddress { get; set; }
        public string? Supervisor { get; set; }
        public string CompanyPhone { get; set; } = null!;
        public string JobTitle { get; set; } = null!;
        public long? EmpositionId { get; set; }
        public string? StartingSalary { get; set; }
        public string? EndingSalary { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long UserId { get; set; }
        public bool CanContactThisEmployer { get; set; }
        public string? LeaveReason { get; set; }
        public string? Responisiblities { get; set; }
        public int ApplicantId { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
    }
}
