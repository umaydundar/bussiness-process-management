using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewProject
    {
        public long Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Logo { get; set; }
        public int? ApplicationCount { get; set; }
    }
}
