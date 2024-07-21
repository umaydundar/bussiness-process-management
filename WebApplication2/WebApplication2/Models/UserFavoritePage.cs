using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class UserFavoritePage
    {
        public int Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string? Url { get; set; }
        public long RefUser { get; set; }
    }
}
