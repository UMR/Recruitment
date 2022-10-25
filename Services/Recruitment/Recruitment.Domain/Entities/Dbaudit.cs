using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Dbaudit
    {
        public int AuditId { get; set; }
        public int UserId { get; set; }
        public DateTime? RevisionStamp { get; set; }
        public string? TableName { get; set; }
        public string? Actions { get; set; }
        public string? Description { get; set; }
        public string? OldData { get; set; }
        public string? NewData { get; set; }
        public string? ChangedColumns { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
