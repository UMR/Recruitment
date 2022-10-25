using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ImpotedContactMaster
    {
        public ImpotedContactMaster()
        {
            ImpotedContactMasterDetails = new HashSet<ImpotedContactMasterDetail>();
        }

        public long ImpotedContactMasterId { get; set; }
        public string ContactId { get; set; } = null!;
        public string? FullName { get; set; }
        public string? EmailAddress { get; set; }
        public int MailConfigurationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual MailConfiguration MailConfiguration { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<ImpotedContactMasterDetail> ImpotedContactMasterDetails { get; set; }
    }
}
