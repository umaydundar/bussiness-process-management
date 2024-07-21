using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableServerDrive
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefServer { get; set; }
        public string Name { get; set; } = null!;
        public string Label { get; set; } = null!;
        public string? Type { get; set; }
        public long SpaceTotal { get; set; }
        public long SpaceFree { get; set; }
    }
}
