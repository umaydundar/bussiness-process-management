using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class AuthScope
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefAuth { get; set; }
        public string App { get; set; } = null!;
        public string Controller { get; set; } = null!;
        public string Action { get; set; } = null!;
    }
}
