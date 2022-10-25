using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InternalMemo
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int ApplicantId { get; set; }
        public string MemoSubject { get; set; } = null!;
        public string MemoContent { get; set; } = null!;
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// New = True, Read = False
        /// </summary>
        public bool Status { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual User Receiver { get; set; } = null!;
        public virtual User Sender { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
