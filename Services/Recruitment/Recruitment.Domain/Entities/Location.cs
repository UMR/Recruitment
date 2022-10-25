using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Location
    {
        public Location()
        {
            ApplicantWorkHistories = new HashSet<ApplicantWorkHistory>();
        }

        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistories { get; set; }
    }
}
