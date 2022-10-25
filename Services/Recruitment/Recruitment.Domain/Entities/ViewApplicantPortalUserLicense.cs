using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ViewApplicantPortalUserLicense
    {
        public long LicenseId { get; set; }
        public string LicenseName { get; set; } = null!;
        public string? LicenseNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public long UserId { get; set; }
        public byte[]? FileData { get; set; }
        public string? FileName { get; set; }
        public DateTime? IssuedDate { get; set; }
        public byte? FileType { get; set; }
    }
}
