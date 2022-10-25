using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ProfilePositionMap
    {
        public long ProfilePositionMapId { get; set; }
        public int PositionId { get; set; }
        public long ProfileTemplateMasterId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Position Position { get; set; } = null!;
        public virtual ProfileTemplateMaster ProfileTemplateMaster { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
