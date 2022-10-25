using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class ViewApplicantPortalUserReference
    {
        public long UserReferenceId { get; set; }
        public string? FullName { get; set; }
        public string NatureOfRelationship { get; set; } = null!;
        public string? CompanyName { get; set; }
        public long? EminstituteId { get; set; }
        public string? RefPhone { get; set; }
        public string RefAddress { get; set; } = null!;
        public long UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
