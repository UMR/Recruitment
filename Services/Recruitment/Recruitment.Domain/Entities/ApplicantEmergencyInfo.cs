using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ApplicantEmergencyInfo
    {
        public long ApplicantEmergencyInfoId { get; set; }
        public long? UserEmergencyInfoId { get; set; }
        public string EmrLastName { get; set; } = null!;
        public string EmrFirstName { get; set; } = null!;
        public string? NatureOfRelationship { get; set; }
        public string? EmrCellPhone { get; set; }
        public string EmrHomePhone { get; set; } = null!;
        public string? EmrWorkPhone { get; set; }
        public byte EmrType { get; set; }
        public int ApplicantId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Applicant Applicant { get; set; } = null!;
        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
