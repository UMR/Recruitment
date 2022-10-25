using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class CancelledApplicantWorkHistory
    {
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
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
