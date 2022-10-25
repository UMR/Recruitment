using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ContactHistory
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int InstitutionId { get; set; }
        public DateTime Date { get; set; }
        public string? Comment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Contact Contact { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Institute Institution { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
