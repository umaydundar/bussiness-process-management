using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class OtpVerificationResult
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefOtpVerificationRequest { get; set; }
        public string? Code { get; set; }
        public string? IpAddress { get; set; }
        public string? Port { get; set; }
        public int Result { get; set; }
    }
}
