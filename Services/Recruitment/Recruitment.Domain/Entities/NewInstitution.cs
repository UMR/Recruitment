using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class NewInstitution
    {
        public string? NhH { get; set; }
        public double? _ { get; set; }
        public string? InstituteName { get; set; }
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? County { get; set; }
        public string? State { get; set; }
        public double? ZipCode { get; set; }
        public string? BedNo { get; set; }
        public string? TelephoneNo { get; set; }
        public string? Website { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
