using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellLearnSpell
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public int LearnSpellId { get; set; }
        public int OverridesSpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
