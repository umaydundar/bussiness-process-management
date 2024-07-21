using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewGithubCommit
    {
        public long Id { get; set; }
        public string? GithubUrl { get; set; }
        public DateTime CommitTime { get; set; }
        public string? Message { get; set; }
        public int? RefApplication { get; set; }
        public long? RefUser { get; set; }
        public DateTime RecordTime { get; set; }
        public string? ApplicationName { get; set; }
        public string Repository { get; set; } = null!;
        public string? UserNameSurname { get; set; }
        public string UserGithubUsername { get; set; } = null!;
        public string? UserPicture { get; set; }
        public long? Additions { get; set; }
        public long? Deletions { get; set; }
        public long? Total { get; set; }
        public string? Sha { get; set; }
        public string? Branch { get; set; }
    }
}
