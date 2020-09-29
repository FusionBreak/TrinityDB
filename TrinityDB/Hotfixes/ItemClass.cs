using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemClass
    {
        public uint Id { get; set; }
        public string ClassName { get; set; }
        public float PriceModifier { get; set; }
        public sbyte ClassId { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
