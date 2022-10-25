using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Contact
    {
        public Contact()
        {
            Aiscontacts = new HashSet<Aiscontact>();
            ConatactPhones = new HashSet<ConatactPhone>();
            ContactHistories = new HashSet<ContactHistory>();
        }

        public int ContactId { get; set; }
        public int InstitutionId { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int? PositionId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public int? DepartmentId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ApplicantId { get; set; }
        public string? BusinessEmail { get; set; }
        public int? ZipCodeId { get; set; }

        public virtual Applicant? Applicant { get; set; }
        public virtual User? CreatedByNavigation { get; set; }
        public virtual Department? Department { get; set; }
        public virtual Institute Institution { get; set; } = null!;
        public virtual Position? Position { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<Aiscontact> Aiscontacts { get; set; }
        public virtual ICollection<ConatactPhone> ConatactPhones { get; set; }
        public virtual ICollection<ContactHistory> ContactHistories { get; set; }
    }
}
