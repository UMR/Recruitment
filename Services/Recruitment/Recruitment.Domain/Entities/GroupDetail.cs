using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class GroupDetail
    {
        public long GroupDetailId { get; set; }
        public long GroupMasterId { get; set; }
        public int ApplicantId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual GroupMaster GroupMaster { get; set; } = null!;
    }
}
