using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpellThreat
    {
        public uint Entry { get; set; }
        public int? FlatMod { get; set; }
        public float PctMod { get; set; }
        public float ApPctMod { get; set; }
    }
}
