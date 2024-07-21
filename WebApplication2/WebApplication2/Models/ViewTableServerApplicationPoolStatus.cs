using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableServerApplicationPoolStatus
    {
        public string ApplicationPool { get; set; } = null!;
        public long RefServer { get; set; }
        public string? Status { get; set; }
        public DateTime? StatusTime { get; set; }
    }
}
