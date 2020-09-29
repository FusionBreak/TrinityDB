using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CalendarEvents
    {
        public ulong EventId { get; set; }
        public ulong Owner { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte EventType { get; set; }
        public int TextureId { get; set; }
        public uint Date { get; set; }
        public uint Flags { get; set; }
        public uint LockDate { get; set; }
    }
}
