using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrFollowerXAbility
    {
        public uint Id { get; set; }
        public ushort GarrAbilityId { get; set; }
        public byte FactionIndex { get; set; }
        public ushort GarrFollowerId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
