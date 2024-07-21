using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableServerApplicationPool
    {
        public string ApplicationPool { get; set; } = null!;
        public DateTime RecordTime { get; set; }
        public long RefServer { get; set; }
        public string? Details { get; set; }
    }
}
