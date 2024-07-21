using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TemplateTaskStep
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefCreateUser { get; set; }
        public long? RefTemplateTask { get; set; }
        public string? Name { get; set; }
        public int? TaskOrderNo { get; set; }
        public bool? HasInput { get; set; }
    }
}
