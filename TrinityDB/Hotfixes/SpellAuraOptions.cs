using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellAuraOptions
    {
        public uint Id { get; set; }
        public int ProcCharges { get; set; }
        public int ProcTypeMask { get; set; }
        public int ProcCategoryRecovery { get; set; }
        public ushort CumulativeAura { get; set; }
        public ushort SpellProcsPerMinuteId { get; set; }
        public byte DifficultyId { get; set; }
        public byte ProcChance { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
