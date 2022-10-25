using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ImportTimeZoneZip
    {
        public double? Zip { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public string? City { get; set; }
        public string? StateId { get; set; }
        public string? StateName { get; set; }
        public string? Zcta { get; set; }
        public double? ParentZcta { get; set; }
        public double? Population { get; set; }
        public double? Density { get; set; }
        public double? CountyFips { get; set; }
        public string? CountyName { get; set; }
        public string? CountyWeights { get; set; }
        public string? CountyNamesAll { get; set; }
        public string? CountyFipsAll { get; set; }
        public string? Imprecise { get; set; }
        public string? Military { get; set; }
        public string? Timezone { get; set; }
    }
}
