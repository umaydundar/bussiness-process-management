using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Application
    {
        public int Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefProject { get; set; }
        public string? RefGithubId { get; set; }
        public string? GithubUrl { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? Description { get; set; }
        public string? Url { get; set; }
        public string? Repository { get; set; }
        public string AppKey { get; set; } = null!;
        public string? ServiceName { get; set; }
        public string? ApplicationPool { get; set; }
        public string? PackageName { get; set; }
        public DateTime? LastConfigUpdateTime { get; set; }
        public DateTime? LastDeployTime { get; set; }
        public string? LastDeployVersion { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
