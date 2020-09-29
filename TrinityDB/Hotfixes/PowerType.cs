using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class PowerType
    {
        public uint Id { get; set; }
        public string NameGlobalStringTag { get; set; }
        public string CostGlobalStringTag { get; set; }
        public float RegenPeace { get; set; }
        public float RegenCombat { get; set; }
        public short MaxBasePower { get; set; }
        public short RegenInterruptTimeMs { get; set; }
        public short Flags { get; set; }
        public sbyte PowerTypeEnum { get; set; }
        public sbyte MinPower { get; set; }
        public sbyte CenterPower { get; set; }
        public sbyte DefaultPower { get; set; }
        public sbyte DisplayModifier { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
