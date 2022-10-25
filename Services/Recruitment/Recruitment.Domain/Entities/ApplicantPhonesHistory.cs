using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantPhonesHistory
    {
        public int Id { get; set; }
        public int ApplicantPhonesId { get; set; }
        public int ApplicantId { get; set; }
        public string PhoneType { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? ExtensionNumber { get; set; }
        public bool IsSuspended { get; set; }
    }
}
