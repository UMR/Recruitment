using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class EyeColor
    {
        public string EyeColorCode { get; set; } = null!;
        public string EyeColor1 { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
