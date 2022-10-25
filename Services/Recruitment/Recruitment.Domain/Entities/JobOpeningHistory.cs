using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class JobOpeningHistory
    {
        public int Id { get; set; }
        public int JobOpeningId { get; set; }
        public int InstituteId { get; set; }
        public int PositionId { get; set; }
        public string Shift { get; set; } = null!;
        public int? AccountId { get; set; }
        public string? JobRequirement { get; set; }
        public string? Status { get; set; }
        public string? Salary { get; set; }
        public string? Telephone { get; set; }
        public DateTime? OpeningDate { get; set; }
        public string? PaymentType { get; set; }
        public double? AmountPercent { get; set; }
        public decimal? AmountFlat { get; set; }
        public string? ContractType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? Recruiters { get; set; }
        public bool? Perpetuity { get; set; }
        public int? NoOfOpening { get; set; }
        public int? PositionFilled { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
