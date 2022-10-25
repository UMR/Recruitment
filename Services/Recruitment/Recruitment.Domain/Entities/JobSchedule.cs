using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class JobSchedule
    {
        public int Id { get; set; }
        public string Shift { get; set; } = null!;
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? Days { get; set; }
        public bool? WeekendWork { get; set; }
        public string? Weekends { get; set; }
        public int JobOpeningId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual JobOpening JobOpening { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
