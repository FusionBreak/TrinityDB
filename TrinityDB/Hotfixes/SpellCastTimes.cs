using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellCastTimes
    {
        public uint Id { get; set; }
        public int Base { get; set; }
        public int Minimum { get; set; }
        public short PerLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
