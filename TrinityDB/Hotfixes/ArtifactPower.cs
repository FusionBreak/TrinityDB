using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArtifactPower
    {
        public float PosX { get; set; }
        public float PosY { get; set; }
        public byte ArtifactId { get; set; }
        public byte Flags { get; set; }
        public byte MaxPurchasableRank { get; set; }
        public byte Tier { get; set; }
        public uint Id { get; set; }
        public int Label { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
