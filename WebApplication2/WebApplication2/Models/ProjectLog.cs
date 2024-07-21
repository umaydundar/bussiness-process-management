using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProjectLog
    {
        public long LogId { get; set; }
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Logo { get; set; }
    }
}
