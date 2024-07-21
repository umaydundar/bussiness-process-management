using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class UserRequestLog
    {
        public long LogId { get; set; }
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long? RefUser { get; set; }
        public string? Token { get; set; }
        public string? Method { get; set; }
        public string? Url { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }
        public string? IpAddress { get; set; }
        public string? Port { get; set; }
        public string? UserAgent { get; set; }
    }
}
