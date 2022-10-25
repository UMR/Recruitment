using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ScreenField
    {
        public ScreenField()
        {
            FieldPermissions = new HashSet<FieldPermission>();
            FieldPermissonSetters = new HashSet<FieldPermissonSetter>();
        }

        public int Id { get; set; }
        public int ScreenId { get; set; }
        public string FieldName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Screen Screen { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<FieldPermission> FieldPermissions { get; set; }
        public virtual ICollection<FieldPermissonSetter> FieldPermissonSetters { get; set; }
    }
}
