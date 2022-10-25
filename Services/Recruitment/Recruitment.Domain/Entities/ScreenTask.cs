using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ScreenTask
    {
        public ScreenTask()
        {
            TaskPermissions = new HashSet<TaskPermission>();
        }

        public int Id { get; set; }
        public int TaskId { get; set; }
        public int ScreenId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Screen Screen { get; set; } = null!;
        public virtual Task Task { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<TaskPermission> TaskPermissions { get; set; }
    }
}
