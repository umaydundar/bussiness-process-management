using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TaskStepTag
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefTask { get; set; }
        public long? RefTag { get; set; }
    }
}
