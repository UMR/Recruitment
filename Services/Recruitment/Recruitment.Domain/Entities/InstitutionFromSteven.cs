using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstitutionFromSteven
    {
        public string? NhH { get; set; }
        public string? _ { get; set; }
        public string? InstitutionName { get; set; }
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? County { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public short? Beds { get; set; }
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
