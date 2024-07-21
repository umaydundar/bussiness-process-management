using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableApplicationLoadbalance
    {
        public long Id { get; set; }
        public string AppKey { get; set; } = null!;
        public string Host { get; set; } = null!;
        public DateTime RecordTime { get; set; }
        public string? Description { get; set; }
        public short EvalOrder { get; set; }
        public bool IsActiveNode { get; set; }
        public DateTime LastTouchTime { get; set; }
        public bool IsEnabled { get; set; }
    }
}
