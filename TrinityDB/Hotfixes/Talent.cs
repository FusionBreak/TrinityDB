using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Talent
    {
        public uint Id { get; set; }
        public string Description { get; set; }
        public uint SpellId { get; set; }
        public uint OverridesSpellId { get; set; }
        public ushort SpecId { get; set; }
        public byte TierId { get; set; }
        public byte ColumnIndex { get; set; }
        public byte Flags { get; set; }
        public byte CategoryMask1 { get; set; }
        public byte CategoryMask2 { get; set; }
        public byte ClassId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
