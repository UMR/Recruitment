using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Recruiter
    {
        public Recruiter()
        {
            Consultants = new HashSet<Consultant>();
        }

        public int RecruiterId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string TelephoneNo { get; set; } = null!;
        public string? Ext { get; set; }
        public string? FaxNo { get; set; }
        public string Email { get; set; } = null!;
        public string? Website { get; set; }
        public string? Comments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<Consultant> Consultants { get; set; }
    }
}
