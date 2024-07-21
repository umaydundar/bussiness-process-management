using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableServerServiceStatus
    {
        public string ServiceName { get; set; } = null!;
        public long RefServer { get; set; }
        public string? Status { get; set; }
        public DateTime? StatusTime { get; set; }
    }
}
