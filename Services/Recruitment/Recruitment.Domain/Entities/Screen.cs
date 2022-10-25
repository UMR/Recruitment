using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Screen
    {
        public Screen()
        {
            ScreenFields = new HashSet<ScreenField>();
            ScreenTasks = new HashSet<ScreenTask>();
        }

        public int ScreenId { get; set; }
        public string Name { get; set; } = null!;
        public int? ParrentScreen { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ScreenField> ScreenFields { get; set; }
        public virtual ICollection<ScreenTask> ScreenTasks { get; set; }
    }
}
