using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ViewUserAuditLog
    {
        public long Id { get; set; }
        public long RefUser { get; set; }
        public DateTime EventTime { get; set; }
        public string EventMessage { get; set; } = null!;
        public string EventOperation { get; set; } = null!;
        public string EventType { get; set; } = null!;
        public string? EventObject { get; set; }
        public string? EventObjectIdName { get; set; }
        public long? EventObjectId { get; set; }
        public DateTime RecordTime { get; set; }
        public string UserNameSurname { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public int UserStatus { get; set; }
        public string UserPhone { get; set; } = null!;
    }
}
