using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpellLearnSpell
    {
        public uint Entry { get; set; }
        public uint SpellId { get; set; }
        public byte Active { get; set; }
    }
}
