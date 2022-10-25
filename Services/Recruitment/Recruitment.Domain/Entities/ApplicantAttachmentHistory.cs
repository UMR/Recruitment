using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantAttachmentHistory
    {
        public int HistoryId { get; set; }
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string Title { get; set; } = null!;
        public short Type { get; set; }
        public string FileName { get; set; } = null!;
        public byte[] FileData { get; set; } = null!;
        public short ResumeStatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UserFileId { get; set; }
    }
}
