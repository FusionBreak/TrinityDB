using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArtifactPowerRank
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public float AuraPointsOverride { get; set; }
        public ushort ItemBonusListId { get; set; }
        public byte RankIndex { get; set; }
        public ushort ArtifactPowerId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
