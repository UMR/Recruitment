using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Pdftemplate
    {
        public Pdftemplate()
        {
            GeneratedFiles = new HashSet<GeneratedFile>();
        }

        public long TermplateId { get; set; }
        public string? FileTypeCode { get; set; }
        public byte[]? FileData { get; set; }
        public string? FileName { get; set; }

        public virtual ICollection<GeneratedFile> GeneratedFiles { get; set; }
    }
}
