using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstituteContract
    {
        public InstituteContract()
        {
            ApplicantWorkHistories = new HashSet<ApplicantWorkHistory>();
        }

        public int Id { get; set; }
        public int InstituteId { get; set; }
        public int PositionId { get; set; }
        public decimal? BillRate { get; set; }
        public decimal? PayRate { get; set; }
        public string? ContractType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? Perpetuity { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Institute Institute { get; set; } = null!;
        public virtual Position Position { get; set; } = null!;
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistories { get; set; }
    }
}
