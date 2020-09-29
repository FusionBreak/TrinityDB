using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class RewardPack
    {
        public uint Id { get; set; }
        public uint Money { get; set; }
        public float ArtifactXpmultiplier { get; set; }
        public sbyte ArtifactXpdifficulty { get; set; }
        public byte ArtifactXpcategoryId { get; set; }
        public int CharTitleId { get; set; }
        public uint TreasurePickerId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
