using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class DefTaskStatus
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefCustomer { get; set; }
        public string? ServiceNo { get; set; }
        public long? RefCreateUser { get; set; }
        public long? RefTemplateTask { get; set; }
        public string? Status { get; set; }
    }
}
