using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ConatactPhone
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string PhoneType { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Extension { get; set; }

        public virtual Contact Contact { get; set; } = null!;
        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
