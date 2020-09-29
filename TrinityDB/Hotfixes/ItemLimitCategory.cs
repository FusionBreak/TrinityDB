using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemLimitCategory
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public byte Quantity { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
