using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class UserSettingsGridView
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public int? ViewId { get; set; }
        public string? FieldValue { get; set; }
        public string? FieldText { get; set; }
        public bool? IsVisible { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User? User { get; set; }
    }
}
