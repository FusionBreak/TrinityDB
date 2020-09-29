using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class RulesetItemUpgrade
    {
        public uint Id { get; set; }
        public int ItemId { get; set; }
        public ushort ItemUpgradeId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
