using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstitutionPhonesHistory
    {
        public int Id { get; set; }
        public int InstitutionPhonesId { get; set; }
        public int InstituteId { get; set; }
        public string PhoneType { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int? PositionId { get; set; }
        public string? Location { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
