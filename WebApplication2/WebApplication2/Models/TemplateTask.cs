using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TemplateTask
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefCustomer { get; set; }
        public string? ServiceNo { get; set; }
        public long? RefCreateUser { get; set; }
        public string? Name { get; set; }
        public string? TimingType { get; set; }
        public long? RefTaskType { get; set; }
        public long? RefDepartment { get; set; }
    }
}
