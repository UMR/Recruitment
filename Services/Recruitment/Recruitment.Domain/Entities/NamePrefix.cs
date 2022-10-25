using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class NamePrefix
    {
        public NamePrefix()
        {
            ApplicantBasicInfoHistories = new HashSet<ApplicantBasicInfoHistory>();
            Applicants = new HashSet<Applicant>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantBasicInfoHistory> ApplicantBasicInfoHistories { get; set; }
        public virtual ICollection<Applicant> Applicants { get; set; }
    }
}
