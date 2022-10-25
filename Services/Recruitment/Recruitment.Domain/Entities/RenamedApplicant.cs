using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class RenamedApplicant
    {
        public int ApplicantId { get; set; }
        public string? ApplicantName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
