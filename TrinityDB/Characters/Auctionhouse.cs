using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class Auctionhouse
    {
        public uint Id { get; set; }
        public ulong Auctioneerguid { get; set; }
        public ulong Itemguid { get; set; }
        public ulong Itemowner { get; set; }
        public ulong Buyoutprice { get; set; }
        public uint Time { get; set; }
        public ulong Buyguid { get; set; }
        public ulong Lastbid { get; set; }
        public ulong Startbid { get; set; }
        public ulong Deposit { get; set; }
    }
}
