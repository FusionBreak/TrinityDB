using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class PrestigeLevelInfo
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int BadgeTextureFileDataId { get; set; }
        public byte PrestigeLevel { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
