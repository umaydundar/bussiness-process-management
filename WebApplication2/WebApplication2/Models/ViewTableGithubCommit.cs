using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableGithubCommit
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Repository { get; set; } = null!;
        public string? Branch { get; set; }
        public string Username { get; set; } = null!;
        public string? Message { get; set; }
        public string? GithubUrl { get; set; }
        public long? Additions { get; set; }
        public long? Deletions { get; set; }
        public long? Total { get; set; }
        public string? Sha { get; set; }
        public DateTime CommitTime { get; set; }
    }
}
