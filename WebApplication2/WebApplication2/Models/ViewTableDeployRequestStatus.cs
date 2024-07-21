using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableDeployRequestStatus
    {
        public long Id { get; set; }
        public long RefApplicationDeployRequest { get; set; }
        public DateTime RecordTime { get; set; }
        public string? StatusMessage { get; set; }
        public string StatusType { get; set; } = null!;
    }
}
