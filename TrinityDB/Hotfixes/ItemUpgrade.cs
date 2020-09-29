using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemUpgrade
    {
        public uint Id { get; set; }
        public uint CurrencyAmount { get; set; }
        public ushort PrerequisiteId { get; set; }
        public ushort CurrencyType { get; set; }
        public byte ItemUpgradePathId { get; set; }
        public byte ItemLevelIncrement { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
