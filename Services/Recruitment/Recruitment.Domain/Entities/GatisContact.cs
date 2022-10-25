using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class GatisContact
    {
        public string? FullName { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
        public Guid ContactId { get; set; }
    }
}
