using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemLimitCategoryCondition
    {
        public uint Id { get; set; }
        public sbyte AddQuantity { get; set; }
        public uint PlayerConditionId { get; set; }
        public int ParentItemLimitCategoryId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
