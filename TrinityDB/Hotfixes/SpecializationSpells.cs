using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpecializationSpells
    {
        public string Description { get; set; }
        public int SpellId { get; set; }
        public int OverridesSpellId { get; set; }
        public ushort SpecId { get; set; }
        public byte DisplayOrder { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
