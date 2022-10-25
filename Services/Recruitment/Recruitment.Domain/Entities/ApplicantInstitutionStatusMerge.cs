using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantInstitutionStatusMerge
    {
        public int ApplicantInstitutionStatusMergeId { get; set; }
        public int InstituteId { get; set; }
        public int InstituteMergeId { get; set; }
        public int ApplicantInstitutionStatusId { get; set; }
        public bool IsActiveStatus { get; set; }

        public virtual InstituteMerge InstituteMerge { get; set; } = null!;
    }
}
