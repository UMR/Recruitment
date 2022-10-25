using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstituteAssociatedEmail
    {
        public int InstituteEmailId { get; set; }
        public int InstituteId { get; set; }
        public string EmailType { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public bool IsSecondary { get; set; }
        public int EmailTypesId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual EmailType EmailTypes { get; set; } = null!;
        public virtual Institute Institute { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
