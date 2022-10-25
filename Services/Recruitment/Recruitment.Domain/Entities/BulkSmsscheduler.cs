using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class BulkSmsscheduler
    {
        public int Id { get; set; }
        public string? ToNumber { get; set; }
        public bool? IsSend { get; set; }
        public DateTime SendDate { get; set; }
        public string? FromNumber { get; set; }
        public string? Smsbody { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
