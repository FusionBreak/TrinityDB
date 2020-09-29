using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArtifactUnlock
    {
        public uint Id { get; set; }
        public ushort ItemBonusListId { get; set; }
        public byte PowerRank { get; set; }
        public uint PowerId { get; set; }
        public uint PlayerConditionId { get; set; }
        public byte ArtifactId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
