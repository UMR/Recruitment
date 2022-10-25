using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstituteAssociatedEmailMerge
    {
        public int InstituteAssociatedEmailMergeId { get; set; }
        public int InstituteId { get; set; }
        public int InstituteMergeId { get; set; }
        public int InstituteEmailId { get; set; }

        public virtual InstituteMerge InstituteMerge { get; set; } = null!;
    }
}
