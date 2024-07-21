using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableGithubIssueSummaryDaily
    {
        public DateTime Date { get; set; }
        public string Username { get; set; } = null!;
        public string Repository { get; set; } = null!;
        public long IssueCount { get; set; }
        public long IssueCountClosed { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
