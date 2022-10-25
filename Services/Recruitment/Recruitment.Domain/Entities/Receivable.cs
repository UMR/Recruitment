using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Receivable
    {
        public int ReceivableId { get; set; }
        public int InterviewId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? BillDate { get; set; }
        public decimal MoniesDue { get; set; }
        public decimal Overdue { get; set; }
        public string? Comments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
