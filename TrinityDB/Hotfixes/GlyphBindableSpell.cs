using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GlyphBindableSpell
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public short GlyphPropertiesId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
