using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class PlayerchoiceResponseRewardCurrency
    {
        public int ChoiceId { get; set; }
        public int ResponseId { get; set; }
        public uint Index { get; set; }
        public uint CurrencyId { get; set; }
        public int Quantity { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
