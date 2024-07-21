using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableApplicationConfig
    {
        public long Id { get; set; }
        public bool IsEncrypted { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string? ConfigDescription { get; set; }
        public string AppKey { get; set; } = null!;
        public string? Host { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
