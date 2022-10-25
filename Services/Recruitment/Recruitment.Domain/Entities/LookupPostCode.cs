using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class LookupPostCode
    {
        public LookupPostCode()
        {
            ApplicantBasicInfoHistories = new HashSet<ApplicantBasicInfoHistory>();
            Applicants = new HashSet<Applicant>();
        }

        public int PostCodeId { get; set; }
        public string PostCode { get; set; } = null!;
        public int CountryId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantBasicInfoHistory> ApplicantBasicInfoHistories { get; set; }
        public virtual ICollection<Applicant> Applicants { get; set; }
    }
}
