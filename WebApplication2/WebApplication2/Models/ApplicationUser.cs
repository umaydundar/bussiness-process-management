using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ApplicationUser
    {
        public long Id { get; set; }
        public long RefApplication { get; set; }
        public long RefUser { get; set; }
        public long RefApplicationUserRole { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
