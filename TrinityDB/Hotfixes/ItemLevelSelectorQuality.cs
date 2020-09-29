using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemLevelSelectorQuality
    {
        public uint Id { get; set; }
        public int QualityItemBonusListId { get; set; }
        public sbyte Quality { get; set; }
        public short ParentIlsqualitySetId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
