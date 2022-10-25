using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class JobOpeningAttribute
    {
        public int JobOpeningId { get; set; }
        public int JobAttributeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual JobAttribute JobAttribute { get; set; } = null!;
        public virtual JobOpening JobOpening { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
