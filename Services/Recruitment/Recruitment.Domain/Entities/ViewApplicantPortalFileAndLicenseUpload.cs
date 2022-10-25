using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ViewApplicantPortalFileAndLicenseUpload
    {
        public long AplicantPortalUserFileId { get; set; }
        public byte? FileType { get; set; }
        public long AplicantPortalUserId { get; set; }
        public string? FileName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
