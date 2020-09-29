using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class BarberShopStyle
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public float CostModifier { get; set; }
        public byte Type { get; set; }
        public byte Race { get; set; }
        public byte Sex { get; set; }
        public byte Data { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
