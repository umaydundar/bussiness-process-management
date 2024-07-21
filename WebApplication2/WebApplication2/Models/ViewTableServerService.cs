using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableServerService
    {
        public string ServiceName { get; set; } = null!;
        public DateTime RecordTime { get; set; }
        public long RefServer { get; set; }
        public string? Details { get; set; }
    }
}
