using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Role
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Label { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
