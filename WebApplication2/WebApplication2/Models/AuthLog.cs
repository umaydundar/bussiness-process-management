using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class AuthLog
    {
        public long LogId { get; set; }
        public string Operation { get; set; } = null!;
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Code { get; set; } = null!;
        public string Label { get; set; } = null!;
    }
}
