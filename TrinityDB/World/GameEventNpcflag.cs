using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GameEventNpcflag
    {
        public byte EventEntry { get; set; }
        public ulong Guid { get; set; }
        public ulong Npcflag { get; set; }
    }
}
