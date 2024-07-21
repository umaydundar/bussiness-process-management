using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TemplateTaskStepInput
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefCreateUser { get; set; }
        public long? RefTemplateTaskStep { get; set; }
        public long? RefInput { get; set; }
        public string? InputLabel { get; set; }
        public string? InputValue { get; set; }
        public bool? IsRequired { get; set; }
        public int? InputOrderNo { get; set; }
    }
}
