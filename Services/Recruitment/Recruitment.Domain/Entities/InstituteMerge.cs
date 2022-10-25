using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstituteMerge
    {
        public InstituteMerge()
        {
            AiscontactMerges = new HashSet<AiscontactMerge>();
            ApplicantInstitutionStatusMerges = new HashSet<ApplicantInstitutionStatusMerge>();
            ContactMerges = new HashSet<ContactMerge>();
            InstituteAssociatedEmailMerges = new HashSet<InstituteAssociatedEmailMerge>();
            InstituteContractMerges = new HashSet<InstituteContractMerge>();
            InstituteNameMerges = new HashSet<InstituteNameMerge>();
            InstitutionLocationMerges = new HashSet<InstitutionLocationMerge>();
            InstitutionPhonesMerges = new HashSet<InstitutionPhonesMerge>();
            JobOpeningMerges = new HashSet<JobOpeningMerge>();
            RecruitmentCommentsMerges = new HashSet<RecruitmentCommentsMerge>();
            RecruitmentFacilitiesMerges = new HashSet<RecruitmentFacilitiesMerge>();
        }

        public int InstituteMergeId { get; set; }
        public int ReplaceByInstituteId { get; set; }
        public int InstituteId { get; set; }
        public int InstituteTypeId { get; set; }
        public string InstituteName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? County { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public string? ZipCode { get; set; }
        public int? NoOfBeds { get; set; }
        public string? Website { get; set; }
        public string? Comments { get; set; }
        public string? ContractType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? PaymentType { get; set; }
        public double? Percentage { get; set; }
        public decimal? FlatRate { get; set; }
        public bool? Perpetuity { get; set; }
        public string? Telephone { get; set; }
        public string? State { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsClient { get; set; }
        public bool? IsBad { get; set; }
        public int? ParentId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[]? FileData { get; set; }
        public string? FileName { get; set; }

        public virtual ICollection<AiscontactMerge> AiscontactMerges { get; set; }
        public virtual ICollection<ApplicantInstitutionStatusMerge> ApplicantInstitutionStatusMerges { get; set; }
        public virtual ICollection<ContactMerge> ContactMerges { get; set; }
        public virtual ICollection<InstituteAssociatedEmailMerge> InstituteAssociatedEmailMerges { get; set; }
        public virtual ICollection<InstituteContractMerge> InstituteContractMerges { get; set; }
        public virtual ICollection<InstituteNameMerge> InstituteNameMerges { get; set; }
        public virtual ICollection<InstitutionLocationMerge> InstitutionLocationMerges { get; set; }
        public virtual ICollection<InstitutionPhonesMerge> InstitutionPhonesMerges { get; set; }
        public virtual ICollection<JobOpeningMerge> JobOpeningMerges { get; set; }
        public virtual ICollection<RecruitmentCommentsMerge> RecruitmentCommentsMerges { get; set; }
        public virtual ICollection<RecruitmentFacilitiesMerge> RecruitmentFacilitiesMerges { get; set; }
    }
}
