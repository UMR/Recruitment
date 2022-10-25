using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class VwApplicantPhone
    {
        public string PhoneNumber { get; set; } = null!;
        public string? ApplicantName { get; set; }
        public int? ApplicantId { get; set; }
    }
}
