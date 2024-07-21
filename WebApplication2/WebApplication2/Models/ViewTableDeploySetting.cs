using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewTableDeploySetting
    {
        public long RefApplication { get; set; }
        public DateTime RecordTime { get; set; }
        public string? DirectoryPathDeploy { get; set; }
        public string? DirectoryPathBackup { get; set; }
        public string? DirectoryPathAssetDownload { get; set; }
    }
}
