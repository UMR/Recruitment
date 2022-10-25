﻿using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantLanguage
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string Name { get; set; } = null!;
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
        public bool CanSpeak { get; set; }
        public bool IsSecondary { get; set; }
        public int LanguageId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Language Language { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
