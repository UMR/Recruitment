using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class GroupMaster
    {
        public GroupMaster()
        {
            GroupDetails = new HashSet<GroupDetail>();
        }

        public long GroupMasterId { get; set; }
        public string GroupName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<GroupDetail> GroupDetails { get; set; }
    }
}
