using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Applicant
    {
        public Applicant()
        {
            AgreementFroms = new HashSet<AgreementFrom>();
            Aiscontacts = new HashSet<Aiscontact>();
            ApplicantAppointments = new HashSet<ApplicantAppointment>();
            ApplicantAttachments = new HashSet<ApplicantAttachment>();
            ApplicantBasicInfoHistories = new HashSet<ApplicantBasicInfoHistory>();
            ApplicantBreaksInEmployments = new HashSet<ApplicantBreaksInEmployment>();
            ApplicantCertifications = new HashSet<ApplicantCertification>();
            ApplicantComments = new HashSet<ApplicantComment>();
            ApplicantContracts = new HashSet<ApplicantContract>();
            ApplicantEducations = new HashSet<ApplicantEducation>();
            ApplicantEmails = new HashSet<ApplicantEmail>();
            ApplicantEmergencyInfos = new HashSet<ApplicantEmergencyInfo>();
            ApplicantInstitutionStatuses = new HashSet<ApplicantInstitutionStatus>();
            ApplicantJobAttributes = new HashSet<ApplicantJobAttribute>();
            ApplicantLanguages = new HashSet<ApplicantLanguage>();
            ApplicantPhones = new HashSet<ApplicantPhone>();
            ApplicantProfiles = new HashSet<ApplicantProfile>();
            ApplicantReferences = new HashSet<ApplicantReference>();
            ApplicantReferralReferees = new HashSet<ApplicantReferral>();
            ApplicantReferralReferrals = new HashSet<ApplicantReferral>();
            ApplicantRelatives = new HashSet<ApplicantRelative>();
            ApplicantSkills = new HashSet<ApplicantSkill>();
            ApplicantSponsors = new HashSet<ApplicantSponsor>();
            ApplicantWorkHistories = new HashSet<ApplicantWorkHistory>();
            Consultants = new HashSet<Consultant>();
            Contacts = new HashSet<Contact>();
            FollowUps = new HashSet<FollowUp>();
            GeneratedFiles = new HashSet<GeneratedFile>();
            GroupDetails = new HashSet<GroupDetail>();
            HepaBhippas = new HashSet<HepaBhippa>();
            ImportedApplicants = new HashSet<ImportedApplicant>();
            InfluenzaVaccinations = new HashSet<InfluenzaVaccination>();
            InternalMemos = new HashSet<InternalMemo>();
            Interviews = new HashSet<Interview>();
            NurseForms = new HashSet<NurseForm>();
            QuickAdds = new HashSet<QuickAdd>();
            RecruitmentComments = new HashSet<RecruitmentComment>();
            RecruitmentFacilities = new HashSet<RecruitmentFacility>();
            TermsConditions = new HashSet<TermsCondition>();
            Uscis = new HashSet<Usci>();
            W9froms = new HashSet<W9from>();
        }

        public int ApplicantId { get; set; }
        public int? PrefixId { get; set; }
        public string? ApplicantName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleInitial { get; set; }
        public string? MaidenName { get; set; }
        public string? StreetAddress { get; set; }
        public string? Apt { get; set; }
        public string? ZipCode { get; set; }
        public int? StateId { get; set; }
        public string? County { get; set; }
        public string? Town { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
        public short? Status { get; set; }
        public int? CountryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? PrimaryOwnerId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? State { get; set; }
        public DateTime? Date { get; set; }
        public string? Salary { get; set; }
        public string? Notify { get; set; }
        public string? PhoneNo { get; set; }
        public string? Fax { get; set; }
        public string? PagerCell { get; set; }
        public string? Home { get; set; }
        public string? Cell { get; set; }
        public string? EMail { get; set; }
        public string? Position { get; set; }
        public string? Location { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsResumePanding { get; set; }
        public string? ImportedApplicantName { get; set; }
        public int? DesiredPositionId { get; set; }
        public bool? IsSponsored { get; set; }
        public int? PlaceOfBirth { get; set; }
        public string? Race { get; set; }
        public byte? Ssntype { get; set; }
        public string? Ssn { get; set; }
        public byte? Sex { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsBad { get; set; }
        public bool? IsClient { get; set; }
        public string? DesiredShift { get; set; }
        public int? VisaStatusId { get; set; }
        public int? HireType { get; set; }
        public int? PostalCodeId { get; set; }
        public int? SuffixId { get; set; }
        public int? CurrentSalaryType { get; set; }
        public string? CurrentSalary { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string? EyeColor { get; set; }
        public string? CountryFromApplied { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? HairColor { get; set; }
        public bool? IsAuthorized { get; set; }
        public bool? IsOldClient { get; set; }
        public bool? IsConvict { get; set; }
        public string? ConvictionDetail { get; set; }

        public virtual Country? Country { get; set; }
        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual Position? DesiredPosition { get; set; }
        public virtual Country? PlaceOfBirthNavigation { get; set; }
        public virtual LookupPostCode? PostalCode { get; set; }
        public virtual NamePrefix? Prefix { get; set; }
        public virtual User? PrimaryOwner { get; set; }
        public virtual Race? RaceNavigation { get; set; }
        public virtual State? StateNavigation { get; set; }
        public virtual NameSuffix? Suffix { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual VisaTypeEntity? VisaStatus { get; set; }
        public virtual ApplicantTemplateMasterProfile? ApplicantTemplateMasterProfile { get; set; }
        public virtual ICollection<AgreementFrom> AgreementFroms { get; set; }
        public virtual ICollection<Aiscontact> Aiscontacts { get; set; }
        public virtual ICollection<ApplicantAppointment> ApplicantAppointments { get; set; }
        public virtual ICollection<ApplicantAttachment> ApplicantAttachments { get; set; }
        public virtual ICollection<ApplicantBasicInfoHistory> ApplicantBasicInfoHistories { get; set; }
        public virtual ICollection<ApplicantBreaksInEmployment> ApplicantBreaksInEmployments { get; set; }
        public virtual ICollection<ApplicantCertification> ApplicantCertifications { get; set; }
        public virtual ICollection<ApplicantComment> ApplicantComments { get; set; }
        public virtual ICollection<ApplicantContract> ApplicantContracts { get; set; }
        public virtual ICollection<ApplicantEducation> ApplicantEducations { get; set; }
        public virtual ICollection<ApplicantEmail> ApplicantEmails { get; set; }
        public virtual ICollection<ApplicantEmergencyInfo> ApplicantEmergencyInfos { get; set; }
        public virtual ICollection<ApplicantInstitutionStatus> ApplicantInstitutionStatuses { get; set; }
        public virtual ICollection<ApplicantJobAttribute> ApplicantJobAttributes { get; set; }
        public virtual ICollection<ApplicantLanguage> ApplicantLanguages { get; set; }
        public virtual ICollection<ApplicantPhone> ApplicantPhones { get; set; }
        public virtual ICollection<ApplicantProfile> ApplicantProfiles { get; set; }
        public virtual ICollection<ApplicantReference> ApplicantReferences { get; set; }
        public virtual ICollection<ApplicantReferral> ApplicantReferralReferees { get; set; }
        public virtual ICollection<ApplicantReferral> ApplicantReferralReferrals { get; set; }
        public virtual ICollection<ApplicantRelative> ApplicantRelatives { get; set; }
        public virtual ICollection<ApplicantSkill> ApplicantSkills { get; set; }
        public virtual ICollection<ApplicantSponsor> ApplicantSponsors { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistories { get; set; }
        public virtual ICollection<Consultant> Consultants { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<FollowUp> FollowUps { get; set; }
        public virtual ICollection<GeneratedFile> GeneratedFiles { get; set; }
        public virtual ICollection<GroupDetail> GroupDetails { get; set; }
        public virtual ICollection<HepaBhippa> HepaBhippas { get; set; }
        public virtual ICollection<ImportedApplicant> ImportedApplicants { get; set; }
        public virtual ICollection<InfluenzaVaccination> InfluenzaVaccinations { get; set; }
        public virtual ICollection<InternalMemo> InternalMemos { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
        public virtual ICollection<NurseForm> NurseForms { get; set; }
        public virtual ICollection<QuickAdd> QuickAdds { get; set; }
        public virtual ICollection<RecruitmentComment> RecruitmentComments { get; set; }
        public virtual ICollection<RecruitmentFacility> RecruitmentFacilities { get; set; }
        public virtual ICollection<TermsCondition> TermsConditions { get; set; }
        public virtual ICollection<Usci> Uscis { get; set; }
        public virtual ICollection<W9from> W9froms { get; set; }
    }
}
