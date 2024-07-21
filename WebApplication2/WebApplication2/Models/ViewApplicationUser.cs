using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewApplicationUser
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefApplication { get; set; }
        public long RefApplicationUserRole { get; set; }
        public long RefUser { get; set; }
        public string UserApplicationRole { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string? UserPicture { get; set; }
        public string UserEmail { get; set; } = null!;
        public string? UserGithubUsername { get; set; }
        public long RefProject { get; set; }
    }
}
