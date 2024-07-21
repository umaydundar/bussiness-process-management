using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableGithubIssueAssignee
    {
        public long RefIssue { get; set; }
        public string Username { get; set; } = null!;
        public DateTime RecordTime { get; set; }
    }
}
