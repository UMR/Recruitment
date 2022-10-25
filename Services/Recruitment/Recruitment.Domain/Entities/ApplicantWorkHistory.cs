using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantWorkHistory
    {
        public ApplicantWorkHistory()
        {
            InversePromotedFromNavigation = new HashSet<ApplicantWorkHistory>();
            InverseReplacement = new HashSet<ApplicantWorkHistory>();
        }

        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int? InstituteId { get; set; }
        public string? City { get; set; }
        public int? PositionId { get; set; }
        public string? ClinicalArea { get; set; }
        public string? JobDescription { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? Todate { get; set; }
        public bool IsContinuing { get; set; }
        public string? Salary { get; set; }
        public int? WorkHourPerWeek { get; set; }
        public string? ReasonForLeaving { get; set; }
        public string? Supervisor { get; set; }
        public string? SupervisorPhone { get; set; }
        public string? OtherTitlesHeldWithEmployee { get; set; }
        public bool? CanContactThisEmployer { get; set; }
        public string? Shift { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? Days { get; set; }
        public bool? WeekendWork { get; set; }
        public string? Weekend { get; set; }
        public string? PositionName { get; set; }
        public int? Aisid { get; set; }
        public int? ReplacementId { get; set; }
        public DateTime? OrientationDate { get; set; }
        public int? HireType { get; set; }
        public int? SalaryType { get; set; }
        public TimeSpan? OrientationStartTime { get; set; }
        public TimeSpan? OrientationEndTime { get; set; }
        public byte? JobEndingType { get; set; }
        public bool? IsPrompted { get; set; }
        public int? PromotedFrom { get; set; }
        public int? LocationId { get; set; }
        public string? OrientationGoogleCalendarEventId { get; set; }
        public string? JobStartGoogleCalendarEventId { get; set; }
        public byte? JobType { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? InstituteContractId { get; set; }
        public decimal? BillRate { get; set; }
        public decimal? PayRate { get; set; }
        public bool? IsSpecial { get; set; }
        public byte? ProfileStatus { get; set; }
        public int? ApplicantContractId { get; set; }
        public string? Responisiblities { get; set; }

        public virtual ApplicantInstitutionStatus? Ais { get; set; }
        public virtual Applicant Applicant { get; set; } = null!;
        public virtual ApplicantContract? ApplicantContract { get; set; }
        public virtual Department? ClinicalAreaNavigation { get; set; }
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Institute? Institute { get; set; }
        public virtual InstituteContract? InstituteContract { get; set; }
        public virtual Location? Location { get; set; }
        public virtual Position? Position { get; set; }
        public virtual ApplicantWorkHistory? PromotedFromNavigation { get; set; }
        public virtual ApplicantWorkHistory? Replacement { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantWorkHistory> InversePromotedFromNavigation { get; set; }
        public virtual ICollection<ApplicantWorkHistory> InverseReplacement { get; set; }
    }
}
