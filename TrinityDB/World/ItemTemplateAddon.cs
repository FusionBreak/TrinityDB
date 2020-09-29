using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class ItemTemplateAddon
    {
        public uint Id { get; set; }
        public uint FlagsCu { get; set; }
        public byte FoodType { get; set; }
        public uint MinMoneyLoot { get; set; }
        public uint MaxMoneyLoot { get; set; }
        public float SpellPpmchance { get; set; }
    }
}
