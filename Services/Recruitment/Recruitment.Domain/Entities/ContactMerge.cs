using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ContactMerge
    {
        public int ContactMergeId { get; set; }
        public int ContactId { get; set; }
        public int InstituteId { get; set; }
        public int InstituteMergeId { get; set; }

        public virtual InstituteMerge InstituteMerge { get; set; } = null!;
    }
}
