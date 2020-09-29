using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class LfgData
    {
        public uint Guid { get; set; }
        public uint Dungeon { get; set; }
        public byte State { get; set; }
    }
}
