using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class OfficialFile
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public byte[] FileData { get; set; } = null!;
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsRequired { get; set; }
        public bool IsAdministrative { get; set; }
        public bool IsContract { get; set; }
        public bool IsBackground { get; set; }
        public string? Title { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
