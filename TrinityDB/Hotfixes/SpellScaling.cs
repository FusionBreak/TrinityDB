using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellScaling
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public short ScalesFromItemLevel { get; set; }
        public int Class { get; set; }
        public uint MinScalingLevel { get; set; }
        public uint MaxScalingLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
