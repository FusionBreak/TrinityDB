using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemDisenchantLoot
    {
        public uint Id { get; set; }
        public ushort MinLevel { get; set; }
        public ushort MaxLevel { get; set; }
        public ushort SkillRequired { get; set; }
        public sbyte Subclass { get; set; }
        public byte Quality { get; set; }
        public sbyte ExpansionId { get; set; }
        public byte Class { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
