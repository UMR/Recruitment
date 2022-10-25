using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstituteType
    {
        public InstituteType()
        {
            Institutes = new HashSet<Institute>();
        }

        public int InstituteTypeId { get; set; }
        public string InstituteType1 { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<Institute> Institutes { get; set; }
    }
}
