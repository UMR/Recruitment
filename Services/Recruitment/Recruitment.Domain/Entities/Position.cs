using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Position
    {
        public Position()
        {
            ApplicantWorkHistories = new HashSet<ApplicantWorkHistory>();
            Applicants = new HashSet<Applicant>();
            Consultants = new HashSet<Consultant>();
            Contacts = new HashSet<Contact>();
            InstituteContracts = new HashSet<InstituteContract>();
            JobOpenings = new HashSet<JobOpening>();
            ProfilePositionMaps = new HashSet<ProfilePositionMap>();
            RecruitmentComments = new HashSet<RecruitmentComment>();
            RecruitmentFacilities = new HashSet<RecruitmentFacility>();
        }

        public int PositionId { get; set; }
        public string PositionName { get; set; } = null!;
        public string? Description { get; set; }
        public long? PositionLicenseRequirementId { get; set; }
        public string? Acronym { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DepartmentId { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Department? Department { get; set; }
        public virtual PositionLicenseRequirement? PositionLicenseRequirement { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistories { get; set; }
        public virtual ICollection<Applicant> Applicants { get; set; }
        public virtual ICollection<Consultant> Consultants { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<InstituteContract> InstituteContracts { get; set; }
        public virtual ICollection<JobOpening> JobOpenings { get; set; }
        public virtual ICollection<ProfilePositionMap> ProfilePositionMaps { get; set; }
        public virtual ICollection<RecruitmentComment> RecruitmentComments { get; set; }
        public virtual ICollection<RecruitmentFacility> RecruitmentFacilities { get; set; }
    }
}
