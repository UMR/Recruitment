using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class EmailType
    {
        public EmailType()
        {
            InstituteAssociatedEmails = new HashSet<InstituteAssociatedEmail>();
        }

        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public bool IsPersonal { get; set; }
        public bool IsOfficial { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<InstituteAssociatedEmail> InstituteAssociatedEmails { get; set; }
    }
}
