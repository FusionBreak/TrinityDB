using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class PlayerLevelstats
    {
        public byte Race { get; set; }
        public byte Class { get; set; }
        public byte Level { get; set; }
        public ushort Str { get; set; }
        public ushort Agi { get; set; }
        public ushort Sta { get; set; }
        public ushort Inte { get; set; }
    }
}
