using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class FirewallRule
    {
        public int Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string? Country { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
