using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewApplicationDeployRequestDone
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefUser { get; set; }
        public long RefApplication { get; set; }
        public long RefServer { get; set; }
        public long RefGithubRelease { get; set; }
        public long RefGithubAsset { get; set; }
        public string ReleaseName { get; set; } = null!;
        public DateTime? DeployTime { get; set; }
        public string UserNameSurname { get; set; } = null!;
        public string? UserGithubUsername { get; set; }
        public string? UserPicture { get; set; }
        public string ApplicationName { get; set; } = null!;
        public string? ApplicationGithubUrl { get; set; }
    }
}
