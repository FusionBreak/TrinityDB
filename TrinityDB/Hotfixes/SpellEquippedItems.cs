using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellEquippedItems
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public int EquippedItemInvTypes { get; set; }
        public int EquippedItemSubclass { get; set; }
        public sbyte EquippedItemClass { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
