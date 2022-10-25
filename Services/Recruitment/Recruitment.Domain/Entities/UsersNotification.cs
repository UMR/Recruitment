using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class UsersNotification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string NotificationText { get; set; } = null!;
        public DateTime NotificationTime { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
