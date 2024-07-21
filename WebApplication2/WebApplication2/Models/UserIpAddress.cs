using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class UserIpAddress
    {
        public long RefUser { get; set; }
        public DateTime RecordTime { get; set; }
        public string IpAddress { get; set; } = null!;
        public string? IpAddress2 { get; set; }
        public string? IpAddress3 { get; set; }
        public string? IpAddress4 { get; set; }
        public string? IpAddress5 { get; set; }
    }
}
