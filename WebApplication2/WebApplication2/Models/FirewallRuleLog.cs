using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class FirewallRuleLog
    {
        public int LogId { get; set; }
        public int Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string? Country { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
