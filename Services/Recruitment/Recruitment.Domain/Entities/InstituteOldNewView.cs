using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class InstituteOldNewView
    {
        public string OldName { get; set; } = null!;
        public int InstituteNameId { get; set; }
        public string? InstituteName { get; set; }
        public int? InstituteId { get; set; }
    }
}
