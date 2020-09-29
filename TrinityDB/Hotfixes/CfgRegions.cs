using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CfgRegions
    {
        public uint Id { get; set; }
        public string Tag { get; set; }
        public uint Raidorigin { get; set; }
        public uint ChallengeOrigin { get; set; }
        public ushort RegionId { get; set; }
        public byte RegionGroupMask { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
