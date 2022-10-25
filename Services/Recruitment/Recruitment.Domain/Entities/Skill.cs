using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Skill
    {
        public Skill()
        {
            ApplicantSkills = new HashSet<ApplicantSkill>();
        }

        public int SkillId { get; set; }
        public string SkillTitle { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantSkill> ApplicantSkills { get; set; }
    }
}
