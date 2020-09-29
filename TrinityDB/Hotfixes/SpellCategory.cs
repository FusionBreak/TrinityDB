using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellCategory
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int ChargeRecoveryTime { get; set; }
        public sbyte Flags { get; set; }
        public byte UsesPerWeek { get; set; }
        public sbyte MaxCharges { get; set; }
        public int TypeMask { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
