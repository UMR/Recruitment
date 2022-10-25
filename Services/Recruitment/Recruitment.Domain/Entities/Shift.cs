using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Shift
    {
        public int ShiftId { get; set; }
        public string Initials { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
