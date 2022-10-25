using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Role
    {
        public Role()
        {
            FieldPermissions = new HashSet<FieldPermission>();
            FieldPermissonSetters = new HashSet<FieldPermissonSetter>();
            MenuPermissions = new HashSet<MenuPermission>();
            TaskPermissions = new HashSet<TaskPermission>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public int? Rank { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<FieldPermission> FieldPermissions { get; set; }
        public virtual ICollection<FieldPermissonSetter> FieldPermissonSetters { get; set; }
        public virtual ICollection<MenuPermission> MenuPermissions { get; set; }
        public virtual ICollection<TaskPermission> TaskPermissions { get; set; }
    }
}
