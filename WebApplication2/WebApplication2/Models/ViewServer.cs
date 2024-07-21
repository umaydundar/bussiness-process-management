using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewServer
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Name { get; set; } = null!;
        public string? Type { get; set; }
        public int? CpuCount { get; set; }
        public int? DriveCount { get; set; }
        public string? Memory { get; set; }
        public string? OsVersion { get; set; }
        public string? ServerStatus { get; set; }
        public bool IsEnabled { get; set; }
        public int? ApplicationCount { get; set; }
        public long? IpAddressCount { get; set; }
        public int EventCount { get; set; }
        public string? ErrorMsg { get; set; }
        public long? CapacityAvailable { get; set; }
        public long? CapacityTotal { get; set; }
        public long? CapacityAvailablePercentage { get; set; }
    }
}
