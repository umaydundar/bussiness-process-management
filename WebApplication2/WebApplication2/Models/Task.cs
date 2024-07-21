using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Task
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefCustomer { get; set; }
        public string? ServiceNo { get; set; }
        public long? RefTemplateTask { get; set; }
        public string? Name { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? RefTaskStep { get; set; }
        public long? RefTaskStatus { get; set; }
        public long? RefDepartment { get; set; }
        public string? Description { get; set; }
        public string? Participants { get; set; }
    }
}
