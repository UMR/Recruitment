using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class UserRank
    {
        public long UserRankId { get; set; }
        public int UserId { get; set; }
        public long RankLookupId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? EnumId { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual RankLookup? Enum { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
