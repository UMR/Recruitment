using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstitutionPhonesExtension
    {
        public int ExtensionId { get; set; }
        public int InstitutionPhonesId { get; set; }
        public string? ExtensionNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual InstitutionPhone InstitutionPhones { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
