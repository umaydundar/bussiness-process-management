using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class UserLoginHistory
    {
        public long LogId { get; set; }
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefUser { get; set; }
        public long? RefOtp { get; set; }
        public string? Token { get; set; }
        public DateTime TokenExpireTime { get; set; }
        public string? IpAddress { get; set; }
        public string? Port { get; set; }
        public string? UserAgent { get; set; }
        public string? UserAgentHash { get; set; }
        public string? AppName { get; set; }
        public string? AppVersion { get; set; }
        public string? AppLanguage { get; set; }
        public string? Platform { get; set; }
        public string? DeviceId { get; set; }
        public string? DeviceBrand { get; set; }
        public string? DeviceModel { get; set; }
        public string? DeviceOs { get; set; }
        public string? DeviceOsversion { get; set; }
    }
}
