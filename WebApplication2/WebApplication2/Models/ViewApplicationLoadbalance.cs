using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewApplicationLoadbalance
    {
        public long Id { get; set; }
        public int RefApplication { get; set; }
        public string? Description { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime RecordTime { get; set; }
        public string ApplicationName { get; set; } = null!;
        public string ApplicationType { get; set; } = null!;
        public long RefProject { get; set; }
        public string ServerName { get; set; } = null!;
        public long RefServer { get; set; }
        public short EvalOrder { get; set; }
        public bool IsActiveNode { get; set; }
        public DateTime LastTouchTime { get; set; }
    }
}
