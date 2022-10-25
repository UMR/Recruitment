using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ImportedApplicant
    {
        public long ImportedApplicantId { get; set; }
        public long ApplicantPortalUserId { get; set; }
        public int ApplicantId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
    }
}
