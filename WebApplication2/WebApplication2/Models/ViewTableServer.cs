using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableServer
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Name { get; set; } = null!;
        public string? Details { get; set; }
        public string? Type { get; set; }
        public int? CpuCount { get; set; }
        public int? DriveCount { get; set; }
        public string? Memory { get; set; }
        public string? OsVersion { get; set; }
        public bool IsEnabled { get; set; }
    }
}
