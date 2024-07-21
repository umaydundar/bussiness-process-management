using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableGithubRepository
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Name { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string? Description { get; set; }
        public string Url { get; set; } = null!;
        public string? UrlArchive { get; set; }
        public string? UrlCommits { get; set; }
        public string? UrlBranches { get; set; }
        public string? UrlCollaborators { get; set; }
        public string? UrlEvents { get; set; }
        public string? UrlIssues { get; set; }
        public string? UrlReleases { get; set; }
        public string? UrlPullRequests { get; set; }
        public string? UrlSsh { get; set; }
        public bool Disabled { get; set; }
        public bool Archived { get; set; }
        public DateTime? TimePush { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeUpdated { get; set; }
    }
}
