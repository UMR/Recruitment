using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class JobOpeningMerge
    {
        public int JobOpeningMergeId { get; set; }
        public int InstituteId { get; set; }
        public int InstituteMergeId { get; set; }
        public int JobOpeningId { get; set; }

        public virtual InstituteMerge InstituteMerge { get; set; } = null!;
    }
}
