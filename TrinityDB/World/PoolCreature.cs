using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class PoolCreature
    {
        public ulong Guid { get; set; }
        public uint PoolEntry { get; set; }
        public float Chance { get; set; }
        public string Description { get; set; }
    }
}
