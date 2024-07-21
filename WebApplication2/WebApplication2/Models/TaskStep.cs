using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TaskStep
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefCreateUser { get; set; }
        public long? RefTask { get; set; }
        public string? StepStatus { get; set; }
        public int? TaskOrderNo { get; set; }
        public string? Description { get; set; }
    }
}
