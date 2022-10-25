using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ViewApplicantPortalAgreementForm
    {
        public long AgreementId { get; set; }
        public string? ContractorName { get; set; }
        public string? StreetAddress { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? StateName { get; set; }
        public string? Notary { get; set; }
        public DateTime? Date { get; set; }
        public long UserId { get; set; }
    }
}
