using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstituteName
    {
        public int InstituteNameId { get; set; }
        public int InstituteId { get; set; }
        public bool IsActive { get; set; }
        public string InstituteName1 { get; set; } = null!;
        public DateTime ChangeDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Institute Institute { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
