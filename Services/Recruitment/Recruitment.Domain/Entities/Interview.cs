using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Interview
    {
        public int InterviewId { get; set; }
        public int ApplicantId { get; set; }
        public int? JobOpeningId { get; set; }
        public string? InterviewerName { get; set; }
        public DateTime InterviewDate { get; set; }
        public string? Comments { get; set; }
        public int? ApplicantInstitutionStatusId { get; set; }
        public string? GoogleCalendarEventId { get; set; }
        public int? Count { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual ApplicantInstitutionStatus? ApplicantInstitutionStatus { get; set; }
        public virtual User? CreatedByNavigation { get; set; }
        public virtual JobOpening? JobOpening { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
