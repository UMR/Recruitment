using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class MergeResult
    {
        public long ResultId { get; set; }
        public int DeleteApplicantId { get; set; }
        public int UpdateApplicantId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Result { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
