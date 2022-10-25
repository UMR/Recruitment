using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class VwApplicanEmail
    {
        public string EmailAddress { get; set; } = null!;
        public string? ApplicantName { get; set; }
        public int? ApplicantId { get; set; }
    }
}
