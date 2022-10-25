using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class CanadianZipCodes202006
    {
        public string PostalCode { get; set; } = null!;
        public int CountryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
