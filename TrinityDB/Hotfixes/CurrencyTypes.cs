using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CurrencyTypes
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint MaxQty { get; set; }
        public uint MaxEarnablePerWeek { get; set; }
        public uint Flags { get; set; }
        public byte CategoryId { get; set; }
        public byte SpellCategory { get; set; }
        public byte Quality { get; set; }
        public int InventoryIconFileId { get; set; }
        public uint SpellWeight { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
