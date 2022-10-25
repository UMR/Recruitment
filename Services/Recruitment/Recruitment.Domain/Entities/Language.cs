﻿using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Language
    {
        public Language()
        {
            ApplicantLanguages = new HashSet<ApplicantLanguage>();
        }

        public int LanguageId { get; set; }
        public string Name { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantLanguage> ApplicantLanguages { get; set; }
    }
}
