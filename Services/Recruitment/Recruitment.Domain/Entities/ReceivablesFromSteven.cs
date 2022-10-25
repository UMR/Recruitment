using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ReceivablesFromSteven
    {
        public string? CompanyName { get; set; }
        public string? CandidateName { get; set; }
        public double? TotalFee { get; set; }
        public double? NetFee { get; set; }
        public double? RefFee { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? MoniesDue { get; set; }
        public DateTime? BillDate { get; set; }
        public string? Float { get; set; }
        public string? Overdue { get; set; }
        public string? TelephoneW { get; set; }
        public string? TelephoneH { get; set; }
        public string? Mobile { get; set; }
        public string? EMailAddress { get; set; }
        public string? Position { get; set; }
        public int? ApplicantId { get; set; }
        public int? InstitutionId { get; set; }
        public int? PositionId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
