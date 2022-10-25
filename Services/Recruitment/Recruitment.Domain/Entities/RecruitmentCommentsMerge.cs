using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class RecruitmentCommentsMerge
    {
        public int RecruitmentCommentsMergeId { get; set; }
        public int InstituteId { get; set; }
        public int InstituteMergeId { get; set; }
        public int CommnetId { get; set; }

        public virtual InstituteMerge InstituteMerge { get; set; } = null!;
    }
}
