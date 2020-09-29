using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class ItemInstanceArtifact
    {
        public ulong ItemGuid { get; set; }
        public ulong Xp { get; set; }
        public uint ArtifactAppearanceId { get; set; }
        public uint ArtifactTierId { get; set; }
    }
}
