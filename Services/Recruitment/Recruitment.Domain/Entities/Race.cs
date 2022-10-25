using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Race
    {
        public Race()
        {
            Applicants = new HashSet<Applicant>();
        }

        public string Race1 { get; set; } = null!;
        public string? RaceCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<Applicant> Applicants { get; set; }
    }
}
