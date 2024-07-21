using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class UserLog
    {
        public long LogId { get; set; }
        public string Operation { get; set; } = null!;
        public long Id { get; set; }
        public long RefRole { get; set; }
        public long RefJobTitle { get; set; }
        public string? Picture { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public int Status { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
