using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ApplicationWikiLog
    {
        public long LogId { get; set; }
        public string Operation { get; set; } = null!;
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefUser { get; set; }
        public long RefApplication { get; set; }
        public long RefWikiCategory { get; set; }
        public string Title { get; set; } = null!;
        public string? Details { get; set; }
    }
}
