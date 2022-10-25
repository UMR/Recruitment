using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class MailTemplate
    {
        public int MailTemplateId { get; set; }
        public int UserId { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string TemplateText { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
