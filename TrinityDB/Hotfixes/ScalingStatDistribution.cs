using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ScalingStatDistribution
    {
        public uint Id { get; set; }
        public ushort PlayerLevelToItemLevelCurveId { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
