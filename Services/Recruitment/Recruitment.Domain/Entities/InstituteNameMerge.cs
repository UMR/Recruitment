using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstituteNameMerge
    {
        public int InstituteNameMergeId { get; set; }
        public int InstituteMergeId { get; set; }
        public int InstituteNameId { get; set; }
        public int InstituteId { get; set; }
        public bool IsActive { get; set; }
        public string InstituteName { get; set; } = null!;
        public DateTime ChangeDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual InstituteMerge InstituteMerge { get; set; } = null!;
    }
}
