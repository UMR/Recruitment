using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class MenuPermission
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int RoleId { get; set; }
        public bool HasPermission { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Menu Menu { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
