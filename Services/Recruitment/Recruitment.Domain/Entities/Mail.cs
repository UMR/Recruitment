using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Mail
    {
        public Mail()
        {
            Attachments = new HashSet<Attachment>();
        }

        public string? FromEmailAddress { get; set; }
        public DateTime? SendTime { get; set; }
        public string? Subject { get; set; }
        public string? Content { get; set; }
        public int UserId { get; set; }
        public string? To { get; set; }
        public string? Cc { get; set; }
        public string? Bcc { get; set; }
        public long Id { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
