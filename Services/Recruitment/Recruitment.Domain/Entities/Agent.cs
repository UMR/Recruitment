using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Entities
{
    public partial class Agent
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string Telephone { get; set; } = null!;
        public string? Ext { get; set; }
        public string? Fax { get; set; }
        public string Email { get; set; } = null!;
        public string? Website { get; set; }
        public string? Comments { get; set; }
    }
}
