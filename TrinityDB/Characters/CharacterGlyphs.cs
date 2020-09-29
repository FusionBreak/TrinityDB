using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterGlyphs
    {
        public ulong Guid { get; set; }
        public byte TalentGroup { get; set; }
        public ushort GlyphId { get; set; }
    }
}
