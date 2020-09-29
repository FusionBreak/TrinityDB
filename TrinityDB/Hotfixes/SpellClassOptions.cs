using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellClassOptions
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public uint SpellClassMask1 { get; set; }
        public uint SpellClassMask2 { get; set; }
        public uint SpellClassMask3 { get; set; }
        public uint SpellClassMask4 { get; set; }
        public byte SpellClassSet { get; set; }
        public uint ModalNextSpell { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
