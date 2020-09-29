using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ModifierTree
    {
        public uint Id { get; set; }
        public int Asset { get; set; }
        public int SecondaryAsset { get; set; }
        public uint Parent { get; set; }
        public byte Type { get; set; }
        public sbyte TertiaryAsset { get; set; }
        public sbyte Operator { get; set; }
        public sbyte Amount { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
