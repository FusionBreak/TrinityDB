using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellPower
    {
        public int ManaCost { get; set; }
        public float PowerCostPct { get; set; }
        public float PowerPctPerSecond { get; set; }
        public int RequiredAuraSpellId { get; set; }
        public float PowerCostMaxPct { get; set; }
        public byte OrderIndex { get; set; }
        public sbyte PowerType { get; set; }
        public uint Id { get; set; }
        public int ManaCostPerLevel { get; set; }
        public int ManaPerSecond { get; set; }
        public uint OptionalCost { get; set; }
        public uint PowerDisplayId { get; set; }
        public int AltPowerBarId { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
