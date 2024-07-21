using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class DiagnosticError
    {
        public long Id { get; set; }
        public string? RefId { get; set; }
        public string? RefIdExternal { get; set; }
        public string? Modul { get; set; }
        public string? Kod { get; set; }
        public string? Metot { get; set; }
        public string? Aciklama { get; set; }
        public string? AciklamaExternal { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
