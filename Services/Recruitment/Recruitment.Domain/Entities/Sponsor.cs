using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Sponsor
    {
        public Sponsor()
        {
            ApplicantSponsors = new HashSet<ApplicantSponsor>();
        }

        public int SponsorId { get; set; }
        public string SponsorName { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantSponsor> ApplicantSponsors { get; set; }
    }
}
