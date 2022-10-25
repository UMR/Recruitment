using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class AgreementFrom
    {
        public long AgreementId { get; set; }
        public int ApplicantId { get; set; }
        public string? ContractorName { get; set; }
        public string? StreetAddress { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? StateName { get; set; }
        public string? Notary { get; set; }
        public DateTime? Date { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
    }
}
