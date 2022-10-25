using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Department
    {
        public Department()
        {
            ApplicantWorkHistories = new HashSet<ApplicantWorkHistory>();
            Contacts = new HashSet<Contact>();
            Positions = new HashSet<Position>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistories { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
