using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TaskStepActionInput
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefTaskStepInput { get; set; }
        public string? InputValue { get; set; }
    }
}
