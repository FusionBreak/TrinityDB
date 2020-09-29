using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemChildEquipment
    {
        public uint Id { get; set; }
        public int ChildItemId { get; set; }
        public byte ChildItemEquipSlot { get; set; }
        public int ParentItemId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
