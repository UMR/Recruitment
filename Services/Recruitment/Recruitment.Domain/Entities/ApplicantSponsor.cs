﻿using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantSponsor
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int SponsorId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Sponsor Sponsor { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
