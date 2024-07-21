using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableGithubIssue
    {
        public long Id { get; set; }
        public string Repository { get; set; } = null!;
        public string Username { get; set; } = null!;
        public int Number { get; set; }
        public string? GithubUrl { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public string? Tags { get; set; }
        public DateTime RecordTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? CloseTime { get; set; }
    }
}
