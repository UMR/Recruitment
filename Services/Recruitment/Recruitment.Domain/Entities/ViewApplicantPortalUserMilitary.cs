using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ViewApplicantPortalUserMilitary
    {
        public long UserMilitaryId { get; set; }
        public string Branch { get; set; } = null!;
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string RankAtDischarge { get; set; } = null!;
        public bool TypeOfDischarge { get; set; }
        public string? DisonourComment { get; set; }
        public long UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
