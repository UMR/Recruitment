﻿using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class User
    {
        public User()
        {
        }

        public int UserId { get; set; }
        public string LoginId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telephone { get; set; }
        public bool Odapermission { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int TimeOut { get; set; }
        public long? AgencyId { get; set; }
        public long? ApplicantTypeId { get; set; }
        

    }
}
