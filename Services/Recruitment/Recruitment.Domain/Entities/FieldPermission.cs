using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class FieldPermission
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ScreenFieldId { get; set; }
        public bool HasPermission { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Role Role { get; set; } = null!;
        public virtual ScreenField ScreenField { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
