using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class JobOpeningComment
    {
        public int CommentId { get; set; }
        public int JobOpeningId { get; set; }
        public string Comment { get; set; } = null!;
        public DateTime CommentDate { get; set; }
        public int UserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual JobOpening JobOpening { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
