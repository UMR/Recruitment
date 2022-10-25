using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantReferral
    {
        public int Id { get; set; }
        public int RefereeId { get; set; }
        public int ReferralId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Applicant Referee { get; set; } = null!;
        public virtual Applicant Referral { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
