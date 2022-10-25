using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class GeneratedFile
    {
        public long GeneratedFileId { get; set; }
        public int ApplicantId { get; set; }
        public byte[]? FileData { get; set; }
        public string? FileName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long TermplateId { get; set; }
        public string? FileTypeCode { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Pdftemplate Termplate { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
