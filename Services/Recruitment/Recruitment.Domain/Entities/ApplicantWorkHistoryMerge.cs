using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantWorkHistoryMerge
    {
        public int ApplicantWorkHistoryMergeId { get; set; }
        public int InstituteId { get; set; }
        public int InstituteMergeId { get; set; }
        public int ApplicantWorkHistoryId { get; set; }
    }
}
