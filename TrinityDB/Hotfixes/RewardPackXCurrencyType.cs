using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class RewardPackXCurrencyType
    {
        public uint Id { get; set; }
        public uint CurrencyTypeId { get; set; }
        public int Quantity { get; set; }
        public uint RewardPackId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
