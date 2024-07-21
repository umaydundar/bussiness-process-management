using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ApplicationUserRole
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string? Name { get; set; }
    }
}
