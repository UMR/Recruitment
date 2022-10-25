using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstituteHistory
    {
        public int Id { get; set; }
        public int InstituteId { get; set; }
        public int InstituteTypeId { get; set; }
        public string InstituteName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? County { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public string? ZipCode { get; set; }
        public int? NoOfBeds { get; set; }
        public string? Website { get; set; }
        public string? Comments { get; set; }
        public string? ContractType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? PaymentType { get; set; }
        public double? Percentage { get; set; }
        public decimal? FlatRate { get; set; }
        public bool? Perpetuity { get; set; }
        public string? Telephone { get; set; }
        public string? State { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsClient { get; set; }
        public bool? IsBad { get; set; }
        public int? ParentId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[]? FileData { get; set; }
        public string? FileName { get; set; }
    }
}
