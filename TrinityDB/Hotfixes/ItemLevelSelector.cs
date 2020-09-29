using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemLevelSelector
    {
        public uint Id { get; set; }
        public ushort MinItemLevel { get; set; }
        public ushort ItemLevelSelectorQualitySetId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
