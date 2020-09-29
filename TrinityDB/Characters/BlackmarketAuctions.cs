using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class BlackmarketAuctions
    {
        public int MarketId { get; set; }
        public ulong CurrentBid { get; set; }
        public int Time { get; set; }
        public int NumBids { get; set; }
        public ulong Bidder { get; set; }
    }
}
