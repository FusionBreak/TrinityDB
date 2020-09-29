using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class RewardPackXItem
    {
        public uint Id { get; set; }
        public int ItemId { get; set; }
        public int ItemQuantity { get; set; }
        public int RewardPackId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
