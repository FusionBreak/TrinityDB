using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemXBonusTree
    {
        public uint Id { get; set; }
        public ushort ItemBonusTreeId { get; set; }
        public int ItemId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
