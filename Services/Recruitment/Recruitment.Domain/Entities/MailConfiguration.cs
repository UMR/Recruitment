using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class MailConfiguration
    {
        public MailConfiguration()
        {
            ImpotedContactMasters = new HashSet<ImpotedContactMaster>();
        }

        public int ConfigurationId { get; set; }
        public string ProfileName { get; set; } = null!;
        public int UserId { get; set; }
        public string? Pop3server { get; set; }
        public int Pop3port { get; set; }
        public bool Pop3enableSsl { get; set; }
        public string? Pop3userName { get; set; }
        public string? Pop3password { get; set; }
        public string? Smtpserver { get; set; }
        public int Smtpport { get; set; }
        public string? SmtpuserName { get; set; }
        public string? Smtppassword { get; set; }
        public bool IsBirthdayMail { get; set; }
        public string? GoogleRefreshToken { get; set; }
        public string? GoogleDriveFolderId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsGoogleApiError { get; set; }
        public string? GoogleToken { get; set; }

        public virtual User? CreatedByNavigation { get; set; }
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<ImpotedContactMaster> ImpotedContactMasters { get; set; }
    }
}
