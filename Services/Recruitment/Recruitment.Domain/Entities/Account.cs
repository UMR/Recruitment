using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Account
    {
        public Account()
        {
            JobOpenings = new HashSet<JobOpening>();
        }

        public int AccountId { get; set; }
        public string AccountName { get; set; } = null!;

        public virtual ICollection<JobOpening> JobOpenings { get; set; }
    }
}
