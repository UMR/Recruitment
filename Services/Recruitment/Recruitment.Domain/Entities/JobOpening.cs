using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class JobOpening
    {
        public JobOpening()
        {
            Interviews = new HashSet<Interview>();
            JobHistories = new HashSet<JobHistory>();
            JobOpeningAttributes = new HashSet<JobOpeningAttribute>();
            JobOpeningComments = new HashSet<JobOpeningComment>();
            JobRequirements = new HashSet<JobRequirement>();
            JobSchedules = new HashSet<JobSchedule>();
        }

        public int JobOpeningId { get; set; }
        public int InstituteId { get; set; }
        public int PositionId { get; set; }
        public string Shift { get; set; } = null!;
        public int? AccountId { get; set; }
        public string? JobRequirement { get; set; }
        public string? Status { get; set; }
        public string? Salary { get; set; }
        public string? Telephone { get; set; }
        public DateTime? OpeningDate { get; set; }
        public string? PaymentType { get; set; }
        public double? AmountPercent { get; set; }
        public decimal? AmountFlat { get; set; }
        public string? ContractType { get; set; }
        public DateTime? ExpirationDate { get; set; }
        /// <summary>
        /// UserId
        /// </summary>
        public string? Recruiters { get; set; }
        public bool? Perpetuity { get; set; }
        public int? NoOfOpening { get; set; }
        public int? PositionFilled { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Account? Account { get; set; }
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Institute Institute { get; set; } = null!;
        public virtual Position Position { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
        public virtual ICollection<JobHistory> JobHistories { get; set; }
        public virtual ICollection<JobOpeningAttribute> JobOpeningAttributes { get; set; }
        public virtual ICollection<JobOpeningComment> JobOpeningComments { get; set; }
        public virtual ICollection<JobRequirement> JobRequirements { get; set; }
        public virtual ICollection<JobSchedule> JobSchedules { get; set; }
    }
}
