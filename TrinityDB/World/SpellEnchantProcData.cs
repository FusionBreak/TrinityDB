using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpellEnchantProcData
    {
        public uint Entry { get; set; }
        public uint CustomChance { get; set; }
        public float Ppmchance { get; set; }
        public uint ProcEx { get; set; }
    }
}
