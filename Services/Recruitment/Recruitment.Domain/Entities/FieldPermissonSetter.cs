using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class FieldPermissonSetter
    {
        public int Id { get; set; }
        public int ScreenFieldId { get; set; }
        public int PermissionSetterRole { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Role PermissionSetterRoleNavigation { get; set; } = null!;
        public virtual ScreenField ScreenField { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
