using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ImportUserFromApplicantPortal
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string? StreetAddress { get; set; }
        public string? Apt { get; set; }
        public string? ZipCode { get; set; }
        public string? Phone { get; set; }
        public string? Ssn { get; set; }
        public DateTime? DateAvailable { get; set; }
        public string? DesiredSalary { get; set; }
        public string? DesiredPosition { get; set; }
        public bool? IsUscitizen { get; set; }
        public bool? IsAuthorized { get; set; }
        public bool? IsOldClient { get; set; }
        public bool? IsConvict { get; set; }
        public string? ConvictionDetail { get; set; }
        public long UserId { get; set; }
        public string? City { get; set; }
        public string? StateName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? CountryOfBirth { get; set; }
        public string? CountryFromApplied { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Height { get; set; }
        public string? EyeColor { get; set; }
        public string? Race { get; set; }
        public string? Weight { get; set; }
        public string? HairColor { get; set; }
    }
}
