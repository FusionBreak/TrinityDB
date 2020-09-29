using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellCategories
    {
        public uint Id { get; set; }
        public short Category { get; set; }
        public short StartRecoveryCategory { get; set; }
        public short ChargeCategory { get; set; }
        public byte DifficultyId { get; set; }
        public sbyte DefenseType { get; set; }
        public sbyte DispelType { get; set; }
        public sbyte Mechanic { get; set; }
        public sbyte PreventionType { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
