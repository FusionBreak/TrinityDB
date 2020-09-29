using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GmComplaintChatlog
    {
        public uint ComplaintId { get; set; }
        public uint LineId { get; set; }
        public uint Timestamp { get; set; }
        public string Text { get; set; }
    }
}
