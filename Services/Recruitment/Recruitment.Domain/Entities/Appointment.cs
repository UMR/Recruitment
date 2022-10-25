using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Appointment
    {
        public Appointment()
        {
            ApplicantAppointments = new HashSet<ApplicantAppointment>();
            InverseRecurrenceParent = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Subject { get; set; } = null!;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? RecurrenceRule { get; set; }
        public int? RecurrenceParentId { get; set; }
        public string? Annotations { get; set; }
        public int User { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual Appointment? RecurrenceParent { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User UserNavigation { get; set; } = null!;
        public virtual ICollection<ApplicantAppointment> ApplicantAppointments { get; set; }
        public virtual ICollection<Appointment> InverseRecurrenceParent { get; set; }
    }
}
