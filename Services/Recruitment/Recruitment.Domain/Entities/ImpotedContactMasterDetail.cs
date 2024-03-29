﻿using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ImpotedContactMasterDetail
    {
        public long ImpotedContactMasterDetailId { get; set; }
        public string EmailAddress { get; set; } = null!;
        public long ImpotedContactMasterId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ImpotedContactMaster ImpotedContactMaster { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
    }
}
