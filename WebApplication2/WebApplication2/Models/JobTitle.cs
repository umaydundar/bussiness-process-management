using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public partial class JobTitle
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string? Name { get; set; }
    }

}

