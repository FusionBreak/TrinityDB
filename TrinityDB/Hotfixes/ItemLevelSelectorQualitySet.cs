using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemLevelSelectorQualitySet
    {
        public uint Id { get; set; }
        public short IlvlRare { get; set; }
        public short IlvlEpic { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
