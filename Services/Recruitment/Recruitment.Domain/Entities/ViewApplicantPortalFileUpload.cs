using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ViewApplicantPortalFileUpload
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? MiddleName { get; set; }
        public byte[] FileData { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long? AplicantPortalUserId { get; set; }
        public long AplicantPortalUserFileId { get; set; }
        public byte FileType { get; set; }
    }
}
