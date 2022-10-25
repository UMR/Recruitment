using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Country
    {
        public Country()
        {
            ApplicantBasicInfoHistories = new HashSet<ApplicantBasicInfoHistory>();
            ApplicantCountries = new HashSet<Applicant>();
            ApplicantPlaceOfBirthNavigations = new HashSet<Applicant>();
            Institutes = new HashSet<Institute>();
            LookupPostCodes = new HashSet<LookupPostCode>();
            States = new HashSet<State>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantBasicInfoHistory> ApplicantBasicInfoHistories { get; set; }
        public virtual ICollection<Applicant> ApplicantCountries { get; set; }
        public virtual ICollection<Applicant> ApplicantPlaceOfBirthNavigations { get; set; }
        public virtual ICollection<Institute> Institutes { get; set; }
        public virtual ICollection<LookupPostCode> LookupPostCodes { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
