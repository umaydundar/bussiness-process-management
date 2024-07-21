using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class RolesAuth
    {
        public long RefRole { get; set; }
        public long RefAuth { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
