using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantSkill
    {
        public int ApplicantId { get; set; }
        public int SkillId { get; set; }
        public DateTime? LastUsed { get; set; }
        public double? YearsOfExperience { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Skill Skill { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
