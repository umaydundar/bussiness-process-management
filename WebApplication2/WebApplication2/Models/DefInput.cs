using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class DefInput
    {
        public long Id { get; set; }
        public DateTime? RecordTime { get; set; }
        public long? RefCustomer { get; set; }
        public string? ServiceNo { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
