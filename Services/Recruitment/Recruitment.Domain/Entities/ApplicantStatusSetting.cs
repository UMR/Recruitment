using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantStatusSetting
    {
        public int SettingId { get; set; }
        public int UserId { get; set; }
        public string FromStatus { get; set; } = null!;
        public string ToStatus { get; set; } = null!;
        public int MovingDays { get; set; }
        public DateTime CreateDate { get; set; }
        public string? Note { get; set; }
        public int? FromStatusId { get; set; }
        public int? ToStatusId { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
