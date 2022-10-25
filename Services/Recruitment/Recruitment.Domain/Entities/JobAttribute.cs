using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class JobAttribute
    {
        public JobAttribute()
        {
            ApplicantJobAttributes = new HashSet<ApplicantJobAttribute>();
            JobOpeningAttributes = new HashSet<JobOpeningAttribute>();
        }

        public int JobAttributeId { get; set; }
        public string AttributeTitle { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantJobAttribute> ApplicantJobAttributes { get; set; }
        public virtual ICollection<JobOpeningAttribute> JobOpeningAttributes { get; set; }
    }
}
