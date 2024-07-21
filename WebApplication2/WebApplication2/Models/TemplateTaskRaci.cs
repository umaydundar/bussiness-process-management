using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TemplateTaskRaci
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefCreateUser { get; set; }
        public long? RefTemplateTask { get; set; }
        public long? RefRole { get; set; }
        public string? RaciType { get; set; }
    }
}
