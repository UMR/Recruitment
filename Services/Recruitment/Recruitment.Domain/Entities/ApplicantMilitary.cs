using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantMilitary
    {
        public long MilitaryId { get; set; }
        public long ApplicantId { get; set; }
        public string? Branch { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? RankAtDischarge { get; set; }
        public bool? TypeOfDischarge { get; set; }
        public string? DisonourComment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
