using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewApplicationLoadbalanceConfig
    {
        public int RefApplication { get; set; }
        public string? Description { get; set; }
        public short FailoverTime { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime RecordTime { get; set; }
        public string ApplicationName { get; set; } = null!;
        public string ApplicationType { get; set; } = null!;
        public long RefProject { get; set; }
        public int? ServerCount { get; set; }
    }
}
