using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class MeetingNote
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string MeetingTitle { get; set; } = null!;
        public string MeetingDescription { get; set; } = null!;
        public string MeetingParticipants { get; set; } = null!;
        public DateTime MeetingDate { get; set; }
    }
}
