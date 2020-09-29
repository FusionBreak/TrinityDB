using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class BlackmarketTemplate
    {
        public int MarketId { get; set; }
        public int SellerNpc { get; set; }
        public uint ItemEntry { get; set; }
        public int Quantity { get; set; }
        public ulong MinBid { get; set; }
        public int Duration { get; set; }
        public float Chance { get; set; }
        public string BonusListIds { get; set; }
    }
}
