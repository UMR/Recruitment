﻿using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantTemplateMasterProfile
    {
        public long ApplicantTemplateMasterProfileId { get; set; }
        public int ApplicantId { get; set; }
        public long ProfileTemplateMasterId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual ProfileTemplateMaster ProfileTemplateMaster { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
