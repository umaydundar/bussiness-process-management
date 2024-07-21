using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TagFollow
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefTag { get; set; }
        public long? RefUser { get; set; }
    }
}
