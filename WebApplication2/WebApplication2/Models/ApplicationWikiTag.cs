using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ApplicationWikiTag
    {
        public long RefApplicationWiki { get; set; }
        public string Tag { get; set; } = null!;
        public DateTime RecordTime { get; set; }
    }
}
