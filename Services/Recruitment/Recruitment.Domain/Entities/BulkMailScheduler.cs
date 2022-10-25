using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class BulkMailScheduler
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public bool? IsSend { get; set; }
        public DateTime SendDate { get; set; }
        public string? FromEmail { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailBody { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
