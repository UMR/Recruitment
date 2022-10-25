using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class HiredCalenderDatum
    {
        public DateTime? CalenderDate { get; set; }
        public int ApplicantId { get; set; }
        public int? Aisid { get; set; }
    }
}
