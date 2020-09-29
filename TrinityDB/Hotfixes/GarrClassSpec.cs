using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrClassSpec
    {
        public string ClassSpec { get; set; }
        public string ClassSpecMale { get; set; }
        public string ClassSpecFemale { get; set; }
        public ushort UiTextureAtlasMemberId { get; set; }
        public ushort GarrFollItemSetId { get; set; }
        public byte FollowerClassLimit { get; set; }
        public byte Flags { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
