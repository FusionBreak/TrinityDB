using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrAbility
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int IconFileDataId { get; set; }
        public ushort Flags { get; set; }
        public ushort FactionChangeGarrAbilityId { get; set; }
        public byte GarrAbilityCategoryId { get; set; }
        public byte GarrFollowerTypeId { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
