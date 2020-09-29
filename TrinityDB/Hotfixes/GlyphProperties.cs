using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GlyphProperties
    {
        public uint Id { get; set; }
        public uint SpellId { get; set; }
        public ushort SpellIconId { get; set; }
        public byte GlyphType { get; set; }
        public byte GlyphExclusiveCategoryId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
