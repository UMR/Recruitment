using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class UserStatusHistory
    {
        public long UserStatusHistoryId { get; set; }
        public int UserId { get; set; }
        public bool FromStatus { get; set; }
        public bool ToStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
