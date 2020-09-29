using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class ItemInstanceArtifactPowers
    {
        public ulong ItemGuid { get; set; }
        public uint ArtifactPowerId { get; set; }
        public byte? PurchasedRank { get; set; }
    }
}
