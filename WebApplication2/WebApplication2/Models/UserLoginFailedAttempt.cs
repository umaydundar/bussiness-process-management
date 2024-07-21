using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class UserLoginFailedAttempt
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefUser { get; set; }
        public string? IpAddress { get; set; }
        public string? Port { get; set; }
        public string? UserAgent { get; set; }
        public string? Platform { get; set; }
    }
}
