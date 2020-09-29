using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SummonProperties
    {
        public uint Id { get; set; }
        public int Flags { get; set; }
        public int Control { get; set; }
        public int Faction { get; set; }
        public int Title { get; set; }
        public int Slot { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
