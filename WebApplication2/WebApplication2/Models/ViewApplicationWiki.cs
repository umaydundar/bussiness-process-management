using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewApplicationWiki
    {
        public long Id { get; set; }
        public long RefApplication { get; set; }
        public long RefUser { get; set; }
        public long RefWikiCategory { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public DateTime RecordTime { get; set; }
        public string UserName { get; set; } = null!;
        public string? UserPicture { get; set; }
        public string ApplicationName { get; set; } = null!;
        public string? ApplicationRepository { get; set; }
        public string ApplicationType { get; set; } = null!;
        public string? Details { get; set; }
    }
}
