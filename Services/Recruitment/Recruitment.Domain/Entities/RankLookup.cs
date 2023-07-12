using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class RankLookup
    {
        public long RankLookupId { get; set; }
        public int EnumId { get; set; }
        public string Rank { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
