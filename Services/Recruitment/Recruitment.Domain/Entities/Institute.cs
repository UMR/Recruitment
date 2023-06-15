using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Institute
    {
        public Institute()
        {
            Aiscontacts = new HashSet<Aiscontact>();
            ApplicantInstitutionStatuses = new HashSet<ApplicantInstitutionStatus>();
            ApplicantWorkHistories = new HashSet<ApplicantWorkHistory>();
            ContactHistories = new HashSet<ContactHistory>();
            Contacts = new HashSet<Contact>();
            InstituteAssociatedEmails = new HashSet<InstituteAssociatedEmail>();
            InstituteContracts = new HashSet<InstituteContract>();
            InstituteNames = new HashSet<InstituteName>();
            InstitutionPhones = new HashSet<InstitutionPhone>();
            InverseParent = new HashSet<Institute>();
            JobOpenings = new HashSet<JobOpening>();
            RecruitmentComments = new HashSet<RecruitmentComment>();
            RecruitmentFacilities = new HashSet<RecruitmentFacility>();
        }

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

        public virtual Country? Country { get; set; }
        public virtual User? CreatedByNavigation { get; set; }
        public virtual InstituteTypeTable InstituteType { get; set; } = null!;
        public virtual Institute? Parent { get; set; }
        public virtual State? StateNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<Aiscontact> Aiscontacts { get; set; }
        public virtual ICollection<ApplicantInstitutionStatus> ApplicantInstitutionStatuses { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistories { get; set; }
        public virtual ICollection<ContactHistory> ContactHistories { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<InstituteAssociatedEmail> InstituteAssociatedEmails { get; set; }
        public virtual ICollection<InstituteContract> InstituteContracts { get; set; }
        public virtual ICollection<InstituteName> InstituteNames { get; set; }
        public virtual ICollection<InstitutionPhone> InstitutionPhones { get; set; }
        public virtual ICollection<Institute> InverseParent { get; set; }
        public virtual ICollection<JobOpening> JobOpenings { get; set; }
        public virtual ICollection<RecruitmentComment> RecruitmentComments { get; set; }
        public virtual ICollection<RecruitmentFacility> RecruitmentFacilities { get; set; }
    }
}
