using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantCertificationHistory
    {
        public int HistoryId { get; set; }
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string Certification { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? Number { get; set; }
        public string? StateIssued { get; set; }
        public DateTime? IssuedDate { get; set; }
        public DateTime? ExpiresDate { get; set; }
        public string? IssueAuthority { get; set; }
        public byte[]? FileData { get; set; }
        public string? FileName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? StateCode { get; set; }
        public long? LicenseId { get; set; }
        public long? UserFileId { get; set; }
    }
}
