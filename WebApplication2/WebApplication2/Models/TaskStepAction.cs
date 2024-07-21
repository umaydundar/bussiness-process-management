using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TaskStepAction
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefTaskStep { get; set; }
        public long? RefCreateUser { get; set; }
        public string? ApprovalStatus { get; set; }
    }
}
