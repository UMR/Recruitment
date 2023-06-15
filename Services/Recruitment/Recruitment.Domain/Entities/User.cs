using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            AgencyCreatedByNavigations = new HashSet<Agency>();
            AgencyUpdatedByNavigations = new HashSet<Agency>();
            AiscontactCreatedByNavigations = new HashSet<Aiscontact>();
            AiscontactUpdatedByNavigations = new HashSet<Aiscontact>();
            AllowedIpCreatedByNavigations = new HashSet<AllowedIp>();
            AllowedIpUpdatedByNavigations = new HashSet<AllowedIp>();
            ApplicantAppointmentCreatedByNavigations = new HashSet<ApplicantAppointment>();
            ApplicantAppointmentUpdatedByNavigations = new HashSet<ApplicantAppointment>();
            ApplicantAttachmentCreatedByNavigations = new HashSet<ApplicantAttachment>();
            ApplicantAttachmentUpdatedByNavigations = new HashSet<ApplicantAttachment>();
            ApplicantBasicInfoHistories = new HashSet<ApplicantBasicInfoHistory>();
            ApplicantBreaksInEmploymentCreatedByNavigations = new HashSet<ApplicantBreaksInEmployment>();
            ApplicantBreaksInEmploymentUpdatedByNavigations = new HashSet<ApplicantBreaksInEmployment>();
            ApplicantCertificationCreatedByNavigations = new HashSet<ApplicantCertification>();
            ApplicantCertificationUpdatedByNavigations = new HashSet<ApplicantCertification>();
            ApplicantCommentCreatedByNavigations = new HashSet<ApplicantComment>();
            ApplicantCommentUpdatedByNavigations = new HashSet<ApplicantComment>();
            ApplicantCommentUsers = new HashSet<ApplicantComment>();
            ApplicantContractCreatedByNavigations = new HashSet<ApplicantContract>();
            ApplicantContractUpdatedByNavigations = new HashSet<ApplicantContract>();
            ApplicantCreatedByNavigations = new HashSet<Applicant>();
            ApplicantEducationCreatedByNavigations = new HashSet<ApplicantEducation>();
            ApplicantEducationUpdatedByNavigations = new HashSet<ApplicantEducation>();
            ApplicantEmailCreatedByNavigations = new HashSet<ApplicantEmail>();
            ApplicantEmailUpdatedByNavigations = new HashSet<ApplicantEmail>();
            ApplicantEmergencyInfoCreatedByNavigations = new HashSet<ApplicantEmergencyInfo>();
            ApplicantEmergencyInfoUpdatedByNavigations = new HashSet<ApplicantEmergencyInfo>();
            ApplicantInstitutionStatusCreatedByNavigations = new HashSet<ApplicantInstitutionStatus>();
            ApplicantInstitutionStatusUpdatedByNavigations = new HashSet<ApplicantInstitutionStatus>();
            ApplicantInstitutionStatusUsers = new HashSet<ApplicantInstitutionStatus>();
            ApplicantJobAttributeCreatedByNavigations = new HashSet<ApplicantJobAttribute>();
            ApplicantJobAttributeUpdatedByNavigations = new HashSet<ApplicantJobAttribute>();
            ApplicantLanguageCreatedByNavigations = new HashSet<ApplicantLanguage>();
            ApplicantLanguageUpdatedByNavigations = new HashSet<ApplicantLanguage>();
            ApplicantPhoneCreatedByNavigations = new HashSet<ApplicantPhone>();
            ApplicantPhoneUpdatedByNavigations = new HashSet<ApplicantPhone>();
            ApplicantPrimaryOwners = new HashSet<Applicant>();
            ApplicantProfileCreatedByNavigations = new HashSet<ApplicantProfile>();
            ApplicantProfileUpdatedByNavigations = new HashSet<ApplicantProfile>();
            ApplicantReferenceCreatedByNavigations = new HashSet<ApplicantReference>();
            ApplicantReferenceUpdatedByNavigations = new HashSet<ApplicantReference>();
            ApplicantReferralCreatedByNavigations = new HashSet<ApplicantReferral>();
            ApplicantReferralUpdatedByNavigations = new HashSet<ApplicantReferral>();
            ApplicantRelativeCreatedByNavigations = new HashSet<ApplicantRelative>();
            ApplicantRelativeUpdatedByNavigations = new HashSet<ApplicantRelative>();
            ApplicantSkillCreatedByNavigations = new HashSet<ApplicantSkill>();
            ApplicantSkillUpdatedByNavigations = new HashSet<ApplicantSkill>();
            ApplicantSponsorCreatedByNavigations = new HashSet<ApplicantSponsor>();
            ApplicantSponsorUpdatedByNavigations = new HashSet<ApplicantSponsor>();
            ApplicantStatusSettingCreatedByNavigations = new HashSet<ApplicantStatusSetting>();
            ApplicantStatusSettingUpdatedByNavigations = new HashSet<ApplicantStatusSetting>();
            ApplicantStatusSettingUsers = new HashSet<ApplicantStatusSetting>();
            ApplicantTemplateMasterProfileCreatedByNavigations = new HashSet<ApplicantTemplateMasterProfile>();
            ApplicantTemplateMasterProfileUpdatedByNavigations = new HashSet<ApplicantTemplateMasterProfile>();
            ApplicantTypeCreatedByNavigations = new HashSet<ApplicantType>();
            ApplicantTypeUpdatedByNavigations = new HashSet<ApplicantType>();
            ApplicantUpdatedByNavigations = new HashSet<Applicant>();
            ApplicantWorkHistoryCreatedByNavigations = new HashSet<ApplicantWorkHistory>();
            ApplicantWorkHistoryUpdatedByNavigations = new HashSet<ApplicantWorkHistory>();
            AppointmentCreatedByNavigations = new HashSet<Appointment>();
            AppointmentUpdatedByNavigations = new HashSet<Appointment>();
            AppointmentUserNavigations = new HashSet<Appointment>();
            AttachmentCreatedByNavigations = new HashSet<Attachment>();
            AttachmentUpdatedByNavigations = new HashSet<Attachment>();
            AutoEmailSetupCreatedByNavigations = new HashSet<AutoEmailSetup>();
            AutoEmailSetupUpdatedByNavigations = new HashSet<AutoEmailSetup>();
            CancelledApplicantWorkHistoryCreatedByNavigations = new HashSet<CancelledApplicantWorkHistory>();
            CancelledApplicantWorkHistoryUpdatedByNavigations = new HashSet<CancelledApplicantWorkHistory>();
            ConatactPhoneCreatedByNavigations = new HashSet<ConatactPhone>();
            ConatactPhoneUpdatedByNavigations = new HashSet<ConatactPhone>();
            ConsultantCreatedByNavigations = new HashSet<Consultant>();
            ConsultantUpdatedByNavigations = new HashSet<Consultant>();
            ContactCreatedByNavigations = new HashSet<Contact>();
            ContactHistoryCreatedByNavigations = new HashSet<ContactHistory>();
            ContactHistoryUpdatedByNavigations = new HashSet<ContactHistory>();
            ContactUpdatedByNavigations = new HashSet<Contact>();
            CountryCreatedByNavigations = new HashSet<Country>();
            CountryUpdatedByNavigations = new HashSet<Country>();
            DbauditCreatedByNavigations = new HashSet<Dbaudit>();
            DbauditUpdatedByNavigations = new HashSet<Dbaudit>();
            DbauditUsers = new HashSet<Dbaudit>();
            DegreeCreatedByNavigations = new HashSet<Degree>();
            DegreeUpdatedByNavigations = new HashSet<Degree>();
            DepartmentCreatedByNavigations = new HashSet<Department>();
            DepartmentUpdatedByNavigations = new HashSet<Department>();
            EmailTypeCreatedByNavigations = new HashSet<EmailType>();
            EmailTypeUpdatedByNavigations = new HashSet<EmailType>();
            FieldPermissionCreatedByNavigations = new HashSet<FieldPermission>();
            FieldPermissionUpdatedByNavigations = new HashSet<FieldPermission>();
            FieldPermissonSetterCreatedByNavigations = new HashSet<FieldPermissonSetter>();
            FieldPermissonSetterUpdatedByNavigations = new HashSet<FieldPermissonSetter>();
            FollowUpCreatedByNavigations = new HashSet<FollowUp>();
            FollowUpUpdatedByNavigations = new HashSet<FollowUp>();
            FollowUpUsers = new HashSet<FollowUp>();
            GeneratedFileCreatedByNavigations = new HashSet<GeneratedFile>();
            GeneratedFileUpdatedByNavigations = new HashSet<GeneratedFile>();
            GroupDetails = new HashSet<GroupDetail>();
            GroupMasterCreatedByNavigations = new HashSet<GroupMaster>();
            GroupMasterUpdatedByNavigations = new HashSet<GroupMaster>();
            HepaBhippaCreatedByNavigations = new HashSet<HepaBhippa>();
            HepaBhippaUpdatedByNavigations = new HashSet<HepaBhippa>();
            ImportedApplicants = new HashSet<ImportedApplicant>();
            ImpotedContactMasterCreatedByNavigations = new HashSet<ImpotedContactMaster>();
            ImpotedContactMasterDetailCreatedByNavigations = new HashSet<ImpotedContactMasterDetail>();
            ImpotedContactMasterDetailUpdatedByNavigations = new HashSet<ImpotedContactMasterDetail>();
            ImpotedContactMasterUpdatedByNavigations = new HashSet<ImpotedContactMaster>();
            InfluenzaVaccinationCreatedByNavigations = new HashSet<InfluenzaVaccination>();
            InfluenzaVaccinationUpdatedByNavigations = new HashSet<InfluenzaVaccination>();
            InstituteAssociatedEmailCreatedByNavigations = new HashSet<InstituteAssociatedEmail>();
            InstituteAssociatedEmailUpdatedByNavigations = new HashSet<InstituteAssociatedEmail>();
            InstituteCreatedByNavigations = new HashSet<Institute>();
            InstituteNameCreatedByNavigations = new HashSet<InstituteName>();
            InstituteNameUpdatedByNavigations = new HashSet<InstituteName>();
            InstituteTypeCreatedByNavigations = new HashSet<InstituteTypeTable>();
            InstituteTypeUpdatedByNavigations = new HashSet<InstituteTypeTable>();
            InstituteUpdatedByNavigations = new HashSet<Institute>();
            InstitutionLocationCreatedByNavigations = new HashSet<InstitutionLocation>();
            InstitutionLocationUpdatedByNavigations = new HashSet<InstitutionLocation>();
            InstitutionPhoneCreatedByNavigations = new HashSet<InstitutionPhone>();
            InstitutionPhoneUpdatedByNavigations = new HashSet<InstitutionPhone>();
            InstitutionPhonesExtensionCreatedByNavigations = new HashSet<InstitutionPhonesExtension>();
            InstitutionPhonesExtensionUpdatedByNavigations = new HashSet<InstitutionPhonesExtension>();
            InternalMemoCreatedByNavigations = new HashSet<InternalMemo>();
            InternalMemoReceivers = new HashSet<InternalMemo>();
            InternalMemoSenders = new HashSet<InternalMemo>();
            InternalMemoUpdatedByNavigations = new HashSet<InternalMemo>();
            InterviewCreatedByNavigations = new HashSet<Interview>();
            InterviewUpdatedByNavigations = new HashSet<Interview>();
            InverseCreatedByNavigation = new HashSet<User>();
            InverseUpdatedByNavigation = new HashSet<User>();
            JobAttributeCreatedByNavigations = new HashSet<JobAttribute>();
            JobAttributeUpdatedByNavigations = new HashSet<JobAttribute>();
            JobHistoryCreatedByNavigations = new HashSet<JobHistory>();
            JobHistoryUpdatedByNavigations = new HashSet<JobHistory>();
            JobOpeningAttributeCreatedByNavigations = new HashSet<JobOpeningAttribute>();
            JobOpeningAttributeUpdatedByNavigations = new HashSet<JobOpeningAttribute>();
            JobOpeningCommentCreatedByNavigations = new HashSet<JobOpeningComment>();
            JobOpeningCommentUpdatedByNavigations = new HashSet<JobOpeningComment>();
            JobOpeningCommentUsers = new HashSet<JobOpeningComment>();
            JobOpeningCreatedByNavigations = new HashSet<JobOpening>();
            JobOpeningUpdatedByNavigations = new HashSet<JobOpening>();
            JobRequirementCreatedByNavigations = new HashSet<JobRequirement>();
            JobRequirementUpdatedByNavigations = new HashSet<JobRequirement>();
            JobScheduleCreatedByNavigations = new HashSet<JobSchedule>();
            JobScheduleUpdatedByNavigations = new HashSet<JobSchedule>();
            LanguageCreatedByNavigations = new HashSet<Language>();
            LanguageUpdatedByNavigations = new HashSet<Language>();
            LocationCreatedByNavigations = new HashSet<Location>();
            LocationUpdatedByNavigations = new HashSet<Location>();
            LookupPostCodeCreatedByNavigations = new HashSet<LookupPostCode>();
            LookupPostCodeUpdatedByNavigations = new HashSet<LookupPostCode>();
            LookupZipCodeCreatedByNavigations = new HashSet<LookupZipCode>();
            LookupZipCodeUpdatedByNavigations = new HashSet<LookupZipCode>();
            MailConfigurationCreatedByNavigations = new HashSet<MailConfiguration>();
            MailConfigurationUpdatedByNavigations = new HashSet<MailConfiguration>();
            MailConfigurationUsers = new HashSet<MailConfiguration>();
            MailCreatedByNavigations = new HashSet<Mail>();
            MailTemplateCreatedByNavigations = new HashSet<MailTemplate>();
            MailTemplateUpdatedByNavigations = new HashSet<MailTemplate>();
            MailUpdatedByNavigations = new HashSet<Mail>();
            MailUsers = new HashSet<Mail>();
            MenuCreatedByNavigations = new HashSet<Menu>();
            MenuPermissionCreatedByNavigations = new HashSet<MenuPermission>();
            MenuPermissionUpdatedByNavigations = new HashSet<MenuPermission>();
            MenuUpdatedByNavigations = new HashSet<Menu>();
            MergeResultCreatedByNavigations = new HashSet<MergeResult>();
            MergeResultUpdatedByNavigations = new HashSet<MergeResult>();
            NamePrefixCreatedByNavigations = new HashSet<NamePrefix>();
            NamePrefixUpdatedByNavigations = new HashSet<NamePrefix>();
            NameSuffixCreatedByNavigations = new HashSet<NameSuffix>();
            NameSuffixUpdatedByNavigations = new HashSet<NameSuffix>();
            NurseFormCreatedByNavigations = new HashSet<NurseForm>();
            NurseFormUpdatedByNavigations = new HashSet<NurseForm>();
            OfficialFileCreatedByNavigations = new HashSet<OfficialFile>();
            OfficialFileUpdatedByNavigations = new HashSet<OfficialFile>();
            PaymentMethodCreatedByNavigations = new HashSet<PaymentMethod>();
            PaymentMethodUpdatedByNavigations = new HashSet<PaymentMethod>();
            PositionCreatedByNavigations = new HashSet<Position>();
            PositionLicenseRequirementCreatedByNavigations = new HashSet<PositionLicenseRequirement>();
            PositionLicenseRequirementUpdatedByNavigations = new HashSet<PositionLicenseRequirement>();
            PositionUpdatedByNavigations = new HashSet<Position>();
            ProfilePositionLicenseRequirementMapCreatedByNavigations = new HashSet<ProfilePositionLicenseRequirementMap>();
            ProfilePositionLicenseRequirementMapUpdatedByNavigations = new HashSet<ProfilePositionLicenseRequirementMap>();
            ProfilePositionMapCreatedByNavigations = new HashSet<ProfilePositionMap>();
            ProfilePositionMapUpdatedByNavigations = new HashSet<ProfilePositionMap>();
            ProfileTemplateDetailCreatedByNavigations = new HashSet<ProfileTemplateDetail>();
            ProfileTemplateDetailUpdatedByNavigations = new HashSet<ProfileTemplateDetail>();
            ProfileTemplateMasterCreatedByNavigations = new HashSet<ProfileTemplateMaster>();
            ProfileTemplateMasterUpdatedByNavigations = new HashSet<ProfileTemplateMaster>();
            QuickAddCreatedByNavigations = new HashSet<QuickAdd>();
            QuickAddUpdatedByNavigations = new HashSet<QuickAdd>();
            RaceCreatedByNavigations = new HashSet<Race>();
            RaceUpdatedByNavigations = new HashSet<Race>();
            RankLookupCreatedByNavigations = new HashSet<RankLookup>();
            RankLookupUpdatedByNavigations = new HashSet<RankLookup>();
            ReceivableCreatedByNavigations = new HashSet<Receivable>();
            ReceivableUpdatedByNavigations = new HashSet<Receivable>();
            RecruiterCreatedByNavigations = new HashSet<Recruiter>();
            RecruiterUpdatedByNavigations = new HashSet<Recruiter>();
            RecruitmentCommentCreatedByNavigations = new HashSet<RecruitmentComment>();
            RecruitmentCommentUpdatedByNavigations = new HashSet<RecruitmentComment>();
            RecruitmentCommentUsers = new HashSet<RecruitmentComment>();
            RecruitmentFacilities05112013CreatedByNavigations = new HashSet<RecruitmentFacilities05112013>();
            RecruitmentFacilities05112013UpdatedByNavigations = new HashSet<RecruitmentFacilities05112013>();
            RecruitmentFacilitiesBakCreatedByNavigations = new HashSet<RecruitmentFacilitiesBak>();
            RecruitmentFacilitiesBakUpdatedByNavigations = new HashSet<RecruitmentFacilitiesBak>();
            RecruitmentFacilityCreatedByNavigations = new HashSet<RecruitmentFacility>();
            RecruitmentFacilityUpdatedByNavigations = new HashSet<RecruitmentFacility>();
            ResultCreatedByNavigations = new HashSet<Result>();
            ResultUpdatedByNavigations = new HashSet<Result>();
            RoleCreatedByNavigations = new HashSet<Role>();
            RoleUpdatedByNavigations = new HashSet<Role>();
            ScreenCreatedByNavigations = new HashSet<Screen>();
            ScreenFieldCreatedByNavigations = new HashSet<ScreenField>();
            ScreenFieldUpdatedByNavigations = new HashSet<ScreenField>();
            ScreenTaskCreatedByNavigations = new HashSet<ScreenTask>();
            ScreenTaskUpdatedByNavigations = new HashSet<ScreenTask>();
            ScreenUpdatedByNavigations = new HashSet<Screen>();
            ShiftCreatedByNavigations = new HashSet<Shift>();
            ShiftUpdatedByNavigations = new HashSet<Shift>();
            SkillCreatedByNavigations = new HashSet<Skill>();
            SkillUpdatedByNavigations = new HashSet<Skill>();
            SponsorCreatedByNavigations = new HashSet<Sponsor>();
            SponsorUpdatedByNavigations = new HashSet<Sponsor>();
            StateCreatedByNavigations = new HashSet<State>();
            StateUpdatedByNavigations = new HashSet<State>();
            TaskCreatedByNavigations = new HashSet<Task>();
            TaskPermissionCreatedByNavigations = new HashSet<TaskPermission>();
            TaskPermissionUpdatedByNavigations = new HashSet<TaskPermission>();
            TaskUpdatedByNavigations = new HashSet<Task>();
            TermsConditionCreatedByNavigations = new HashSet<TermsCondition>();
            TermsConditionUpdatedByNavigations = new HashSet<TermsCondition>();
            TimeAttendanceReasonCreatedByNavigations = new HashSet<TimeAttendanceReason>();
            TimeAttendanceReasonUpdatedByNavigations = new HashSet<TimeAttendanceReason>();
            UserRankCreatedByNavigations = new HashSet<UserRank>();
            UserRankUpdatedByNavigations = new HashSet<UserRank>();
            UserSettingCreatedByNavigations = new HashSet<UserSetting>();
            UserSettingUpdatedByNavigations = new HashSet<UserSetting>();
            UserSettingsGridViewCreatedByNavigations = new HashSet<UserSettingsGridView>();
            UserSettingsGridViewUpdatedByNavigations = new HashSet<UserSettingsGridView>();
            UserSettingsGridViewUsers = new HashSet<UserSettingsGridView>();
            UsersNotificationCreatedByNavigations = new HashSet<UsersNotification>();
            UsersNotificationUpdatedByNavigations = new HashSet<UsersNotification>();
            UsersNotificationUsers = new HashSet<UsersNotification>();
            WorkHistoryPrintConfigCreatedByNavigations = new HashSet<WorkHistoryPrintConfig>();
            WorkHistoryPrintConfigUpdatedByNavigations = new HashSet<WorkHistoryPrintConfig>();
            WorkHistoryPrintConfigUsers = new HashSet<WorkHistoryPrintConfig>();
        }

        public int UserId { get; set; }
        public string LoginId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telephone { get; set; }
        /// <summary>
        /// Permission For Acess the application outside from allowed zone/domain
        /// </summary>
        public bool Odapermission { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int TimeOut { get; set; }
        public long? AgencyId { get; set; }

        public virtual Agency? Agency { get; set; }
        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<Agency> AgencyCreatedByNavigations { get; set; }
        public virtual ICollection<Agency> AgencyUpdatedByNavigations { get; set; }
        public virtual ICollection<Aiscontact> AiscontactCreatedByNavigations { get; set; }
        public virtual ICollection<Aiscontact> AiscontactUpdatedByNavigations { get; set; }
        public virtual ICollection<AllowedIp> AllowedIpCreatedByNavigations { get; set; }
        public virtual ICollection<AllowedIp> AllowedIpUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantAppointment> ApplicantAppointmentCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantAppointment> ApplicantAppointmentUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantAttachment> ApplicantAttachmentCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantAttachment> ApplicantAttachmentUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantBasicInfoHistory> ApplicantBasicInfoHistories { get; set; }
        public virtual ICollection<ApplicantBreaksInEmployment> ApplicantBreaksInEmploymentCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantBreaksInEmployment> ApplicantBreaksInEmploymentUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantCertification> ApplicantCertificationCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantCertification> ApplicantCertificationUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantComment> ApplicantCommentCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantComment> ApplicantCommentUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantComment> ApplicantCommentUsers { get; set; }
        public virtual ICollection<ApplicantContract> ApplicantContractCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantContract> ApplicantContractUpdatedByNavigations { get; set; }
        public virtual ICollection<Applicant> ApplicantCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantEducation> ApplicantEducationCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantEducation> ApplicantEducationUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantEmail> ApplicantEmailCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantEmail> ApplicantEmailUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantEmergencyInfo> ApplicantEmergencyInfoCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantEmergencyInfo> ApplicantEmergencyInfoUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantInstitutionStatus> ApplicantInstitutionStatusCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantInstitutionStatus> ApplicantInstitutionStatusUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantInstitutionStatus> ApplicantInstitutionStatusUsers { get; set; }
        public virtual ICollection<ApplicantJobAttribute> ApplicantJobAttributeCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantJobAttribute> ApplicantJobAttributeUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantLanguage> ApplicantLanguageCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantLanguage> ApplicantLanguageUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantPhone> ApplicantPhoneCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantPhone> ApplicantPhoneUpdatedByNavigations { get; set; }
        public virtual ICollection<Applicant> ApplicantPrimaryOwners { get; set; }
        public virtual ICollection<ApplicantProfile> ApplicantProfileCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantProfile> ApplicantProfileUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantReference> ApplicantReferenceCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantReference> ApplicantReferenceUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantReferral> ApplicantReferralCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantReferral> ApplicantReferralUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantRelative> ApplicantRelativeCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantRelative> ApplicantRelativeUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantSkill> ApplicantSkillCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantSkill> ApplicantSkillUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantSponsor> ApplicantSponsorCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantSponsor> ApplicantSponsorUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantStatusSetting> ApplicantStatusSettingCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantStatusSetting> ApplicantStatusSettingUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantStatusSetting> ApplicantStatusSettingUsers { get; set; }
        public virtual ICollection<ApplicantTemplateMasterProfile> ApplicantTemplateMasterProfileCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantTemplateMasterProfile> ApplicantTemplateMasterProfileUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantType> ApplicantTypeCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantType> ApplicantTypeUpdatedByNavigations { get; set; }
        public virtual ICollection<Applicant> ApplicantUpdatedByNavigations { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistoryCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistoryUpdatedByNavigations { get; set; }
        public virtual ICollection<Appointment> AppointmentCreatedByNavigations { get; set; }
        public virtual ICollection<Appointment> AppointmentUpdatedByNavigations { get; set; }
        public virtual ICollection<Appointment> AppointmentUserNavigations { get; set; }
        public virtual ICollection<Attachment> AttachmentCreatedByNavigations { get; set; }
        public virtual ICollection<Attachment> AttachmentUpdatedByNavigations { get; set; }
        public virtual ICollection<AutoEmailSetup> AutoEmailSetupCreatedByNavigations { get; set; }
        public virtual ICollection<AutoEmailSetup> AutoEmailSetupUpdatedByNavigations { get; set; }
        public virtual ICollection<CancelledApplicantWorkHistory> CancelledApplicantWorkHistoryCreatedByNavigations { get; set; }
        public virtual ICollection<CancelledApplicantWorkHistory> CancelledApplicantWorkHistoryUpdatedByNavigations { get; set; }
        public virtual ICollection<ConatactPhone> ConatactPhoneCreatedByNavigations { get; set; }
        public virtual ICollection<ConatactPhone> ConatactPhoneUpdatedByNavigations { get; set; }
        public virtual ICollection<Consultant> ConsultantCreatedByNavigations { get; set; }
        public virtual ICollection<Consultant> ConsultantUpdatedByNavigations { get; set; }
        public virtual ICollection<Contact> ContactCreatedByNavigations { get; set; }
        public virtual ICollection<ContactHistory> ContactHistoryCreatedByNavigations { get; set; }
        public virtual ICollection<ContactHistory> ContactHistoryUpdatedByNavigations { get; set; }
        public virtual ICollection<Contact> ContactUpdatedByNavigations { get; set; }
        public virtual ICollection<Country> CountryCreatedByNavigations { get; set; }
        public virtual ICollection<Country> CountryUpdatedByNavigations { get; set; }
        public virtual ICollection<Dbaudit> DbauditCreatedByNavigations { get; set; }
        public virtual ICollection<Dbaudit> DbauditUpdatedByNavigations { get; set; }
        public virtual ICollection<Dbaudit> DbauditUsers { get; set; }
        public virtual ICollection<Degree> DegreeCreatedByNavigations { get; set; }
        public virtual ICollection<Degree> DegreeUpdatedByNavigations { get; set; }
        public virtual ICollection<Department> DepartmentCreatedByNavigations { get; set; }
        public virtual ICollection<Department> DepartmentUpdatedByNavigations { get; set; }
        public virtual ICollection<EmailType> EmailTypeCreatedByNavigations { get; set; }
        public virtual ICollection<EmailType> EmailTypeUpdatedByNavigations { get; set; }
        public virtual ICollection<FieldPermission> FieldPermissionCreatedByNavigations { get; set; }
        public virtual ICollection<FieldPermission> FieldPermissionUpdatedByNavigations { get; set; }
        public virtual ICollection<FieldPermissonSetter> FieldPermissonSetterCreatedByNavigations { get; set; }
        public virtual ICollection<FieldPermissonSetter> FieldPermissonSetterUpdatedByNavigations { get; set; }
        public virtual ICollection<FollowUp> FollowUpCreatedByNavigations { get; set; }
        public virtual ICollection<FollowUp> FollowUpUpdatedByNavigations { get; set; }
        public virtual ICollection<FollowUp> FollowUpUsers { get; set; }
        public virtual ICollection<GeneratedFile> GeneratedFileCreatedByNavigations { get; set; }
        public virtual ICollection<GeneratedFile> GeneratedFileUpdatedByNavigations { get; set; }
        public virtual ICollection<GroupDetail> GroupDetails { get; set; }
        public virtual ICollection<GroupMaster> GroupMasterCreatedByNavigations { get; set; }
        public virtual ICollection<GroupMaster> GroupMasterUpdatedByNavigations { get; set; }
        public virtual ICollection<HepaBhippa> HepaBhippaCreatedByNavigations { get; set; }
        public virtual ICollection<HepaBhippa> HepaBhippaUpdatedByNavigations { get; set; }
        public virtual ICollection<ImportedApplicant> ImportedApplicants { get; set; }
        public virtual ICollection<ImpotedContactMaster> ImpotedContactMasterCreatedByNavigations { get; set; }
        public virtual ICollection<ImpotedContactMasterDetail> ImpotedContactMasterDetailCreatedByNavigations { get; set; }
        public virtual ICollection<ImpotedContactMasterDetail> ImpotedContactMasterDetailUpdatedByNavigations { get; set; }
        public virtual ICollection<ImpotedContactMaster> ImpotedContactMasterUpdatedByNavigations { get; set; }
        public virtual ICollection<InfluenzaVaccination> InfluenzaVaccinationCreatedByNavigations { get; set; }
        public virtual ICollection<InfluenzaVaccination> InfluenzaVaccinationUpdatedByNavigations { get; set; }
        public virtual ICollection<InstituteAssociatedEmail> InstituteAssociatedEmailCreatedByNavigations { get; set; }
        public virtual ICollection<InstituteAssociatedEmail> InstituteAssociatedEmailUpdatedByNavigations { get; set; }
        public virtual ICollection<Institute> InstituteCreatedByNavigations { get; set; }
        public virtual ICollection<InstituteName> InstituteNameCreatedByNavigations { get; set; }
        public virtual ICollection<InstituteName> InstituteNameUpdatedByNavigations { get; set; }
        public virtual ICollection<InstituteTypeTable> InstituteTypeCreatedByNavigations { get; set; }
        public virtual ICollection<InstituteTypeTable> InstituteTypeUpdatedByNavigations { get; set; }
        public virtual ICollection<Institute> InstituteUpdatedByNavigations { get; set; }
        public virtual ICollection<InstitutionLocation> InstitutionLocationCreatedByNavigations { get; set; }
        public virtual ICollection<InstitutionLocation> InstitutionLocationUpdatedByNavigations { get; set; }
        public virtual ICollection<InstitutionPhone> InstitutionPhoneCreatedByNavigations { get; set; }
        public virtual ICollection<InstitutionPhone> InstitutionPhoneUpdatedByNavigations { get; set; }
        public virtual ICollection<InstitutionPhonesExtension> InstitutionPhonesExtensionCreatedByNavigations { get; set; }
        public virtual ICollection<InstitutionPhonesExtension> InstitutionPhonesExtensionUpdatedByNavigations { get; set; }
        public virtual ICollection<InternalMemo> InternalMemoCreatedByNavigations { get; set; }
        public virtual ICollection<InternalMemo> InternalMemoReceivers { get; set; }
        public virtual ICollection<InternalMemo> InternalMemoSenders { get; set; }
        public virtual ICollection<InternalMemo> InternalMemoUpdatedByNavigations { get; set; }
        public virtual ICollection<Interview> InterviewCreatedByNavigations { get; set; }
        public virtual ICollection<Interview> InterviewUpdatedByNavigations { get; set; }
        public virtual ICollection<User> InverseCreatedByNavigation { get; set; }
        public virtual ICollection<User> InverseUpdatedByNavigation { get; set; }
        public virtual ICollection<JobAttribute> JobAttributeCreatedByNavigations { get; set; }
        public virtual ICollection<JobAttribute> JobAttributeUpdatedByNavigations { get; set; }
        public virtual ICollection<JobHistory> JobHistoryCreatedByNavigations { get; set; }
        public virtual ICollection<JobHistory> JobHistoryUpdatedByNavigations { get; set; }
        public virtual ICollection<JobOpeningAttribute> JobOpeningAttributeCreatedByNavigations { get; set; }
        public virtual ICollection<JobOpeningAttribute> JobOpeningAttributeUpdatedByNavigations { get; set; }
        public virtual ICollection<JobOpeningComment> JobOpeningCommentCreatedByNavigations { get; set; }
        public virtual ICollection<JobOpeningComment> JobOpeningCommentUpdatedByNavigations { get; set; }
        public virtual ICollection<JobOpeningComment> JobOpeningCommentUsers { get; set; }
        public virtual ICollection<JobOpening> JobOpeningCreatedByNavigations { get; set; }
        public virtual ICollection<JobOpening> JobOpeningUpdatedByNavigations { get; set; }
        public virtual ICollection<JobRequirement> JobRequirementCreatedByNavigations { get; set; }
        public virtual ICollection<JobRequirement> JobRequirementUpdatedByNavigations { get; set; }
        public virtual ICollection<JobSchedule> JobScheduleCreatedByNavigations { get; set; }
        public virtual ICollection<JobSchedule> JobScheduleUpdatedByNavigations { get; set; }
        public virtual ICollection<Language> LanguageCreatedByNavigations { get; set; }
        public virtual ICollection<Language> LanguageUpdatedByNavigations { get; set; }
        public virtual ICollection<Location> LocationCreatedByNavigations { get; set; }
        public virtual ICollection<Location> LocationUpdatedByNavigations { get; set; }
        public virtual ICollection<LookupPostCode> LookupPostCodeCreatedByNavigations { get; set; }
        public virtual ICollection<LookupPostCode> LookupPostCodeUpdatedByNavigations { get; set; }
        public virtual ICollection<LookupZipCode> LookupZipCodeCreatedByNavigations { get; set; }
        public virtual ICollection<LookupZipCode> LookupZipCodeUpdatedByNavigations { get; set; }
        public virtual ICollection<MailConfiguration> MailConfigurationCreatedByNavigations { get; set; }
        public virtual ICollection<MailConfiguration> MailConfigurationUpdatedByNavigations { get; set; }
        public virtual ICollection<MailConfiguration> MailConfigurationUsers { get; set; }
        public virtual ICollection<Mail> MailCreatedByNavigations { get; set; }
        public virtual ICollection<MailTemplate> MailTemplateCreatedByNavigations { get; set; }
        public virtual ICollection<MailTemplate> MailTemplateUpdatedByNavigations { get; set; }
        public virtual ICollection<Mail> MailUpdatedByNavigations { get; set; }
        public virtual ICollection<Mail> MailUsers { get; set; }
        public virtual ICollection<Menu> MenuCreatedByNavigations { get; set; }
        public virtual ICollection<MenuPermission> MenuPermissionCreatedByNavigations { get; set; }
        public virtual ICollection<MenuPermission> MenuPermissionUpdatedByNavigations { get; set; }
        public virtual ICollection<Menu> MenuUpdatedByNavigations { get; set; }
        public virtual ICollection<MergeResult> MergeResultCreatedByNavigations { get; set; }
        public virtual ICollection<MergeResult> MergeResultUpdatedByNavigations { get; set; }
        public virtual ICollection<NamePrefix> NamePrefixCreatedByNavigations { get; set; }
        public virtual ICollection<NamePrefix> NamePrefixUpdatedByNavigations { get; set; }
        public virtual ICollection<NameSuffix> NameSuffixCreatedByNavigations { get; set; }
        public virtual ICollection<NameSuffix> NameSuffixUpdatedByNavigations { get; set; }
        public virtual ICollection<NurseForm> NurseFormCreatedByNavigations { get; set; }
        public virtual ICollection<NurseForm> NurseFormUpdatedByNavigations { get; set; }
        public virtual ICollection<OfficialFile> OfficialFileCreatedByNavigations { get; set; }
        public virtual ICollection<OfficialFile> OfficialFileUpdatedByNavigations { get; set; }
        public virtual ICollection<PaymentMethod> PaymentMethodCreatedByNavigations { get; set; }
        public virtual ICollection<PaymentMethod> PaymentMethodUpdatedByNavigations { get; set; }
        public virtual ICollection<Position> PositionCreatedByNavigations { get; set; }
        public virtual ICollection<PositionLicenseRequirement> PositionLicenseRequirementCreatedByNavigations { get; set; }
        public virtual ICollection<PositionLicenseRequirement> PositionLicenseRequirementUpdatedByNavigations { get; set; }
        public virtual ICollection<Position> PositionUpdatedByNavigations { get; set; }
        public virtual ICollection<ProfilePositionLicenseRequirementMap> ProfilePositionLicenseRequirementMapCreatedByNavigations { get; set; }
        public virtual ICollection<ProfilePositionLicenseRequirementMap> ProfilePositionLicenseRequirementMapUpdatedByNavigations { get; set; }
        public virtual ICollection<ProfilePositionMap> ProfilePositionMapCreatedByNavigations { get; set; }
        public virtual ICollection<ProfilePositionMap> ProfilePositionMapUpdatedByNavigations { get; set; }
        public virtual ICollection<ProfileTemplateDetail> ProfileTemplateDetailCreatedByNavigations { get; set; }
        public virtual ICollection<ProfileTemplateDetail> ProfileTemplateDetailUpdatedByNavigations { get; set; }
        public virtual ICollection<ProfileTemplateMaster> ProfileTemplateMasterCreatedByNavigations { get; set; }
        public virtual ICollection<ProfileTemplateMaster> ProfileTemplateMasterUpdatedByNavigations { get; set; }
        public virtual ICollection<QuickAdd> QuickAddCreatedByNavigations { get; set; }
        public virtual ICollection<QuickAdd> QuickAddUpdatedByNavigations { get; set; }
        public virtual ICollection<Race> RaceCreatedByNavigations { get; set; }
        public virtual ICollection<Race> RaceUpdatedByNavigations { get; set; }
        public virtual ICollection<RankLookup> RankLookupCreatedByNavigations { get; set; }
        public virtual ICollection<RankLookup> RankLookupUpdatedByNavigations { get; set; }
        public virtual ICollection<Receivable> ReceivableCreatedByNavigations { get; set; }
        public virtual ICollection<Receivable> ReceivableUpdatedByNavigations { get; set; }
        public virtual ICollection<Recruiter> RecruiterCreatedByNavigations { get; set; }
        public virtual ICollection<Recruiter> RecruiterUpdatedByNavigations { get; set; }
        public virtual ICollection<RecruitmentComment> RecruitmentCommentCreatedByNavigations { get; set; }
        public virtual ICollection<RecruitmentComment> RecruitmentCommentUpdatedByNavigations { get; set; }
        public virtual ICollection<RecruitmentComment> RecruitmentCommentUsers { get; set; }
        public virtual ICollection<RecruitmentFacilities05112013> RecruitmentFacilities05112013CreatedByNavigations { get; set; }
        public virtual ICollection<RecruitmentFacilities05112013> RecruitmentFacilities05112013UpdatedByNavigations { get; set; }
        public virtual ICollection<RecruitmentFacilitiesBak> RecruitmentFacilitiesBakCreatedByNavigations { get; set; }
        public virtual ICollection<RecruitmentFacilitiesBak> RecruitmentFacilitiesBakUpdatedByNavigations { get; set; }
        public virtual ICollection<RecruitmentFacility> RecruitmentFacilityCreatedByNavigations { get; set; }
        public virtual ICollection<RecruitmentFacility> RecruitmentFacilityUpdatedByNavigations { get; set; }
        public virtual ICollection<Result> ResultCreatedByNavigations { get; set; }
        public virtual ICollection<Result> ResultUpdatedByNavigations { get; set; }
        public virtual ICollection<Role> RoleCreatedByNavigations { get; set; }
        public virtual ICollection<Role> RoleUpdatedByNavigations { get; set; }
        public virtual ICollection<Screen> ScreenCreatedByNavigations { get; set; }
        public virtual ICollection<ScreenField> ScreenFieldCreatedByNavigations { get; set; }
        public virtual ICollection<ScreenField> ScreenFieldUpdatedByNavigations { get; set; }
        public virtual ICollection<ScreenTask> ScreenTaskCreatedByNavigations { get; set; }
        public virtual ICollection<ScreenTask> ScreenTaskUpdatedByNavigations { get; set; }
        public virtual ICollection<Screen> ScreenUpdatedByNavigations { get; set; }
        public virtual ICollection<Shift> ShiftCreatedByNavigations { get; set; }
        public virtual ICollection<Shift> ShiftUpdatedByNavigations { get; set; }
        public virtual ICollection<Skill> SkillCreatedByNavigations { get; set; }
        public virtual ICollection<Skill> SkillUpdatedByNavigations { get; set; }
        public virtual ICollection<Sponsor> SponsorCreatedByNavigations { get; set; }
        public virtual ICollection<Sponsor> SponsorUpdatedByNavigations { get; set; }
        public virtual ICollection<State> StateCreatedByNavigations { get; set; }
        public virtual ICollection<State> StateUpdatedByNavigations { get; set; }
        public virtual ICollection<Task> TaskCreatedByNavigations { get; set; }
        public virtual ICollection<TaskPermission> TaskPermissionCreatedByNavigations { get; set; }
        public virtual ICollection<TaskPermission> TaskPermissionUpdatedByNavigations { get; set; }
        public virtual ICollection<Task> TaskUpdatedByNavigations { get; set; }
        public virtual ICollection<TermsCondition> TermsConditionCreatedByNavigations { get; set; }
        public virtual ICollection<TermsCondition> TermsConditionUpdatedByNavigations { get; set; }
        public virtual ICollection<TimeAttendanceReason> TimeAttendanceReasonCreatedByNavigations { get; set; }
        public virtual ICollection<TimeAttendanceReason> TimeAttendanceReasonUpdatedByNavigations { get; set; }
        public virtual ICollection<UserRank> UserRankCreatedByNavigations { get; set; }
        public virtual ICollection<UserRank> UserRankUpdatedByNavigations { get; set; }
        public virtual ICollection<UserSetting> UserSettingCreatedByNavigations { get; set; }
        public virtual ICollection<UserSetting> UserSettingUpdatedByNavigations { get; set; }
        public virtual ICollection<UserSettingsGridView> UserSettingsGridViewCreatedByNavigations { get; set; }
        public virtual ICollection<UserSettingsGridView> UserSettingsGridViewUpdatedByNavigations { get; set; }
        public virtual ICollection<UserSettingsGridView> UserSettingsGridViewUsers { get; set; }
        public virtual ICollection<UsersNotification> UsersNotificationCreatedByNavigations { get; set; }
        public virtual ICollection<UsersNotification> UsersNotificationUpdatedByNavigations { get; set; }
        public virtual ICollection<UsersNotification> UsersNotificationUsers { get; set; }
        public virtual ICollection<WorkHistoryPrintConfig> WorkHistoryPrintConfigCreatedByNavigations { get; set; }
        public virtual ICollection<WorkHistoryPrintConfig> WorkHistoryPrintConfigUpdatedByNavigations { get; set; }
        public virtual ICollection<WorkHistoryPrintConfig> WorkHistoryPrintConfigUsers { get; set; }
    }
}
