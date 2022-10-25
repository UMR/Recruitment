using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public int UserId { get; set; }
        public int ApplicantId { get; set; }
        public int InstituteId { get; set; }
        public int PositionId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? Todate { get; set; }
        public string Shift { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public string? Comment { get; set; }
        public DateTime InformDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal Hour { get; set; }
    }
}
