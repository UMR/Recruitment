using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class View2
    {
        public int InstituteId { get; set; }
        public int InstituteTypeId { get; set; }
        public string? Description { get; set; }
        public string InstituteName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? County { get; set; }
        public int? CountryId { get; set; }
        public string? CountryName { get; set; }
        public int? StateId { get; set; }
        public string? StateName { get; set; }
        public string? ZipCode { get; set; }
        public int? NoOfBeds { get; set; }
        public string? Telephone { get; set; }
        public string? Website { get; set; }
        public string? Comments { get; set; }
    }
}
