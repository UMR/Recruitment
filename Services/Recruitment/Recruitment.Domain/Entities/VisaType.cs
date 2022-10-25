using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class VisaType
    {
        public VisaType()
        {
            Applicants = new HashSet<Applicant>();
        }

        public int Id { get; set; }
        public string? VisaType1 { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Applicant> Applicants { get; set; }
    }
}
