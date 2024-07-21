using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableApplicationLoadbalanceConfig
    {
        public string AppKey { get; set; } = null!;
        public DateTime RecordTime { get; set; }
        public string? Description { get; set; }
        public bool IsEnabled { get; set; }
        public short FailoverTime { get; set; }
    }
}
