using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class AiscontactMerge
    {
        public int AiscontactMergeId { get; set; }
        public int InstituteId { get; set; }
        public int InstituteMergeId { get; set; }
        public int Id { get; set; }

        public virtual InstituteMerge InstituteMerge { get; set; } = null!;
    }
}
