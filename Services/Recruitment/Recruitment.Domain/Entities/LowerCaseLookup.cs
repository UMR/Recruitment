using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class LowerCaseLookup
    {
        public long Id { get; set; }
        public string? Word { get; set; }
    }
}
