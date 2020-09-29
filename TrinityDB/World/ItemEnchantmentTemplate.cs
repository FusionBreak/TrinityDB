using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class ItemEnchantmentTemplate
    {
        public uint Entry { get; set; }
        public byte Type { get; set; }
        public uint Ench { get; set; }
        public float Chance { get; set; }
    }
}
