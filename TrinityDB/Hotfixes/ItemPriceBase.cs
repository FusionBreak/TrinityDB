using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemPriceBase
    {
        public uint Id { get; set; }
        public float Armor { get; set; }
        public float Weapon { get; set; }
        public ushort ItemLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
