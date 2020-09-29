using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GemProperties
    {
        public uint Id { get; set; }
        public uint Type { get; set; }
        public ushort EnchantId { get; set; }
        public ushort MinItemLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
