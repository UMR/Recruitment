using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstitutionPhone
    {
        public InstitutionPhone()
        {
            InstitutionPhonesExtensions = new HashSet<InstitutionPhonesExtension>();
        }

        public int Id { get; set; }
        public int InstituteId { get; set; }
        public string PhoneType { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int? PositionId { get; set; }
        public string? Location { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Institute Institute { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<InstitutionPhonesExtension> InstitutionPhonesExtensions { get; set; }
    }
}
