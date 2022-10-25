using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class UserEntryExit
    {
        public int UserId { get; set; }
        public DateTime LogInTime { get; set; }
        public DateTime? LogOutTime { get; set; }
        public string SessionId { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
