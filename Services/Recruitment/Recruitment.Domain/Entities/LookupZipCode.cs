using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class LookupZipCode
    {
        public int Id { get; set; }
        public string ZipCode { get; set; } = null!;
        public string City { get; set; } = null!;
        public string StateAbbr { get; set; } = null!;
        public string County { get; set; } = null!;
        public string? Type { get; set; }
        public string? AcceptableCities { get; set; }
        public string? UnacceptableCities { get; set; }
        public string? Timezone { get; set; }
        public double? AreaCodes { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? WorldRegion { get; set; }
        public string? Country { get; set; }
        public double? Decommissioned { get; set; }
        public double? EstimatedPopulation { get; set; }
        public string? Notes { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
