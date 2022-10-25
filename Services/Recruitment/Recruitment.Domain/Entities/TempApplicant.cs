using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class TempApplicant
    {
        public int? ApplicantId { get; set; }
        public string? ApplicantName { get; set; }
        public string? InstituteName { get; set; }
        public string? PositionName { get; set; }
        public int? ApplicantIdDx { get; set; }
        public int? InstituteId { get; set; }
        public int? PositionId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
