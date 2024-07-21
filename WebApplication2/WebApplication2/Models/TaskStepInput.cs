using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TaskStepInput
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefTaskStep { get; set; }
        public long? RefInput { get; set; }
        public string? InputLabel { get; set; }
        public string? InputValue { get; set; }
        public bool? IsRequired { get; set; }
        public int? InputOrderNo { get; set; }
    }
}
