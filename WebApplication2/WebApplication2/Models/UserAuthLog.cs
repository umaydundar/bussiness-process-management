using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class UserAuthLog
    {
        public long LogId { get; set; }
        public string Operation { get; set; } = null!;
        public long Id { get; set; }
        public long RefUser { get; set; }
        public long RefAuth { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
