using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemRandomProperties
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public ushort Enchantment1 { get; set; }
        public ushort Enchantment2 { get; set; }
        public ushort Enchantment3 { get; set; }
        public ushort Enchantment4 { get; set; }
        public ushort Enchantment5 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
