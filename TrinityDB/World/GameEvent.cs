﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GameEvent
    {
        public byte EventEntry { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public ulong Occurence { get; set; }
        public ulong Length { get; set; }
        public uint Holiday { get; set; }
        public string Description { get; set; }
        public byte WorldEvent { get; set; }
        public byte? Announce { get; set; }
    }
}
