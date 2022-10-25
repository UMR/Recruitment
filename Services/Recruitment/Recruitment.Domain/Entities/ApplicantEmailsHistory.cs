using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantEmailsHistory
    {
        public int Id { get; set; }
        public int ApplicantEmailsId { get; set; }
        public int ApplicantId { get; set; }
        public string EmailType { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsSuspended { get; set; }
    }
}
