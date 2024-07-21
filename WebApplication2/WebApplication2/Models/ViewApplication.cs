using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewApplication
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public long RefProject { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime? LastConfigUpdateTime { get; set; }
        public DateTime? LastDeployTime { get; set; }
        public string? LastDeployVersion { get; set; }
        public string? ServiceName { get; set; }
        public string? ApplicationPool { get; set; }
        public string? PackageName { get; set; }
        public DateTime RecordTime { get; set; }
        public string? Repository { get; set; }
        public string Type { get; set; } = null!;
        public string? Url { get; set; }
        public string AppKey { get; set; } = null!;
        public string? GithubUrl { get; set; }
        public string? RefGithubId { get; set; }
        public string? ProjectName { get; set; }
        public int? ServerCount { get; set; }
        public int? ConfigCount { get; set; }
        public bool? LoadBalanceEnabled { get; set; }
        public int? WikiCount { get; set; }
        public int? UserCount { get; set; }
    }
}
