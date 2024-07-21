using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewGithubIssue
    {
        public long Id { get; set; }
        public string? GithubUrl { get; set; }
        public int? RefApplication { get; set; }
        public DateTime RecordTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string? Body { get; set; }
        public long? RefUser { get; set; }
        public string? Tags { get; set; }
        public string? Title { get; set; }
        public string GithubUsername { get; set; } = null!;
        public string? UserNameSurname { get; set; }
        public string? UserPicture { get; set; }
        public string? ApplicationName { get; set; }
        public string? ApplicationType { get; set; }
        public string Repository { get; set; } = null!;
        public int Number { get; set; }
        public string IssueStatus { get; set; } = null!;
    }
}
