using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Attachment
    {
        public long AttachmentId { get; set; }
        public string FileName { get; set; } = null!;
        public byte[] FileContent { get; set; } = null!;
        public long? MailId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Mail? Mail { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
