using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewUser
    {
        public long Id { get; set; }
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public long RefJobTitle { get; set; }
        public int UserStatus { get; set; }
        public string? JobTitle { get; set; }
        public string? GithubUsername { get; set; }
        public string? Picture { get; set; }
        public int RecordStatus { get; set; }
        public DateTime? StartDateOfWork { get; set; }
        public DateTime? EndDateOfWork { get; set; }
        public long RefRole { get; set; }
        public string RoleName { get; set; } = null!;
        public string RoleLabel { get; set; } = null!;
    }
}
