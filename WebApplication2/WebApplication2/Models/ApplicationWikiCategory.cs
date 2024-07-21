using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ApplicationWikiCategory
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Name { get; set; } = null!;
    }
}
