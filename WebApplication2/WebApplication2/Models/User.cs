using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class User
    {
        public long Id { get; set; }
        public long RefRole { get; set; }
        public long RefJobTitle { get; set; }
        public string? Picture { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? GithubUsername { get; set; }
        public int Status { get; set; }
        public DateTime RecordTime { get; set; }
        public DateTime? StartDateOfWork { get; set; }
        public DateTime? EndDateOfWork { get; set; }
        
    }
}
