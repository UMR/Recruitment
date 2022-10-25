using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class JobHistory
    {
        public int Id { get; set; }
        public int JobOpeningId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = null!;
        public string? Comment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual JobOpening JobOpening { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
