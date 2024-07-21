using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class FirewallRuleIpAddress
    {
        public int Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefFirewallRule { get; set; }
        public string IpAddress { get; set; } = null!;
        public string? Description { get; set; }
    }
}
