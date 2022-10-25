using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ImportUserFromApplicantPortalNewLogic
    {
        public long UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? MiddleName { get; set; }
        public bool IsVerified { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? StreetAddress { get; set; }
        public string? ZipCode { get; set; }
        public string? Apt { get; set; }
        public string? City { get; set; }
        public string? StateName { get; set; }
        public string? Phone { get; set; }
    }
}
