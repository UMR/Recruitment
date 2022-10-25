using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class HairColor
    {
        public string HairColorCode { get; set; } = null!;
        public string HairColor1 { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
