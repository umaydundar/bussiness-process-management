using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class FirewallRuleIpAddressLog
    {
        public int LogId { get; set; }
        public int Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefFirewallRule { get; set; }
        public string? IpAddress { get; set; }
        public string? Description { get; set; }
    }
}
