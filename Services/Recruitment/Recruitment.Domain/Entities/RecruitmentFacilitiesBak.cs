using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class RecruitmentFacilitiesBak
    {
        public long Pk { get; set; }
        public string? InstitutionName { get; set; }
        public string? Town { get; set; }
        public string? County { get; set; }
        public string? State { get; set; }
        public string? Applicant { get; set; }
        public string? Position { get; set; }
        public string? Location { get; set; }
        public string? EMail { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? PagerCell { get; set; }
        public string? Home { get; set; }
        public string? Cell { get; set; }
        public string? HomeTown { get; set; }
        public string? HomeCounty { get; set; }
        public string? HomeAddress { get; set; }
        public string? HomeState { get; set; }
        public string? Salary { get; set; }
        public DateTime? Date { get; set; }
        public string? Notify { get; set; }
        public int? ApplicantId { get; set; }
        public int? InstitueId { get; set; }
        public int? PositionId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
