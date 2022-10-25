using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class RankNoView
    {
        public int? RankNo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int ProfileDetailRank { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
        public string NodeName { get; set; } = null!;
        public long? OwnerId { get; set; }
        public long ProfileTemplateMasterId { get; set; }
        public long ProfileTemplateDetailId { get; set; }
        public long ApplicantProfileId { get; set; }
        public long Expr1 { get; set; }
        public long Expr2 { get; set; }
        public int? ApploicantAttachmentId { get; set; }
        public int? ApplicantCertificationId { get; set; }
        public int ApplicantId { get; set; }
    }
}
