using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class MeetingNoteFile
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long RefMeetingNote { get; set; }
        public string MeetingFile { get; set; } = null!;
    }
}
