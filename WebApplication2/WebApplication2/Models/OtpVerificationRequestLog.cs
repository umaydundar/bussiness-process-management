using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class OtpVerificationRequestLog
    {
        public long LogId { get; set; }
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefUser { get; set; }
        public string App { get; set; } = null!;
        public string Receiver { get; set; } = null!;
        public string Channel { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public string? ReferenceCode { get; set; }
        public int ExpiresInSeconds { get; set; }
        public DateTime ExpireTime { get; set; }
        public string? Code { get; set; }
    }
}
