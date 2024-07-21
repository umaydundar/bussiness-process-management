using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableServerStatus
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefServer { get; set; }
        public string ServerStatus { get; set; } = null!;
        public string? Details { get; set; }
        public DateTime ServerTime { get; set; }
    }
}
