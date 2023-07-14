using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantBasicInfoHistory
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int? PrefixId { get; set; }
        public string? ApplicantName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleInitial { get; set; }
        public string MaidenName { get; set; } = null!;
        public string? StreetAddress { get; set; }
        public string? Apt { get; set; }
        public string? ZipCode { get; set; }
        public int? StateId { get; set; }
        public string? County { get; set; }
        public string? Town { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
        public short? Status { get; set; }
        public int? CountryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? PrimaryOwnerId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? State { get; set; }
        public DateTime? Date { get; set; }
        public string? Salary { get; set; }
        public string? Notify { get; set; }
        public string? PhoneNo { get; set; }
        public string? Fax { get; set; }
        public string? PagerCell { get; set; }
        public string? Home { get; set; }
        public string? Cell { get; set; }
        public string? EMail { get; set; }
        public string? Position { get; set; }
        public string? Location { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsResumePanding { get; set; }
        public string? ImportedApplicantName { get; set; }
        public int? DesiredPositionId { get; set; }
        public bool? IsSponsored { get; set; }
        public int? PlaceOfBirth { get; set; }
        public string? Race { get; set; }
        public byte? Ssntype { get; set; }
        public string? Ssn { get; set; }
        public byte? Sex { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsBad { get; set; }
        public bool? IsClient { get; set; }
        public string? DesiredShift { get; set; }
        public int? VisaStatusId { get; set; }
        public int? HireType { get; set; }
        public int? PostalCodeId { get; set; }
        public int? SuffixId { get; set; }
        public int? CurrentSalaryType { get; set; }
        public string? CurrentSalary { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string? EyeColor { get; set; }
        public string? CountryFromApplied { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? HairColor { get; set; }
        public bool? IsAuthorized { get; set; }
        public bool? IsOldClient { get; set; }
        public bool? IsConvict { get; set; }
        public string? ConvictionDetail { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual Country? Country { get; set; }
        public virtual PostCode? PostalCode { get; set; }
        public virtual NamePrefix? Prefix { get; set; }
        public virtual State? StateNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
