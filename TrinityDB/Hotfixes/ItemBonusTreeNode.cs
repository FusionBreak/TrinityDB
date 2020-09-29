using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemBonusTreeNode
    {
        public uint Id { get; set; }
        public ushort ChildItemBonusTreeId { get; set; }
        public ushort ChildItemBonusListId { get; set; }
        public ushort ChildItemLevelSelectorId { get; set; }
        public byte ItemContext { get; set; }
        public ushort ParentItemBonusTreeId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
