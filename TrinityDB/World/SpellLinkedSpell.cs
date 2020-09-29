using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpellLinkedSpell
    {
        public int SpellTrigger { get; set; }
        public int SpellEffect { get; set; }
        public byte Type { get; set; }
        public string Comment { get; set; }
    }
}
