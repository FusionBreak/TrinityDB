using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellCastingRequirements
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public ushort MinFactionId { get; set; }
        public ushort RequiredAreasId { get; set; }
        public ushort RequiresSpellFocus { get; set; }
        public byte FacingCasterFlags { get; set; }
        public sbyte MinReputation { get; set; }
        public byte RequiredAuraVision { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
