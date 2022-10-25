using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantReference
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string Name { get; set; } = null!;
        public string? Company { get; set; }
        public string? Address { get; set; }
        public string? Telephone { get; set; }
        public string Email { get; set; } = null!;
        public string? NatureOfRelationship { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UserReferenceId { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
