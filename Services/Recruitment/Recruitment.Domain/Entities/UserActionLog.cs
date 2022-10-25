using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class UserActionLog
    {
        public int UserId { get; set; }
        public string ActionComment { get; set; } = null!;
        public DateTime DeletedTime { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
