using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class AuctionHouse
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public ushort FactionId { get; set; }
        public byte DepositRate { get; set; }
        public byte ConsignmentRate { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
