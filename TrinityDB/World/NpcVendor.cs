using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class NpcVendor
    {
        public uint Entry { get; set; }
        public short Slot { get; set; }
        public int Item { get; set; }
        public uint Maxcount { get; set; }
        public uint Incrtime { get; set; }
        public uint ExtendedCost { get; set; }
        public byte Type { get; set; }
        public string BonusListIds { get; set; }
        public uint PlayerConditionId { get; set; }
        public byte IgnoreFiltering { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
