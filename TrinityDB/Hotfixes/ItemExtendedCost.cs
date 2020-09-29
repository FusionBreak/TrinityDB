using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemExtendedCost
    {
        public uint Id { get; set; }
        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public int ItemId3 { get; set; }
        public int ItemId4 { get; set; }
        public int ItemId5 { get; set; }
        public uint CurrencyCount1 { get; set; }
        public uint CurrencyCount2 { get; set; }
        public uint CurrencyCount3 { get; set; }
        public uint CurrencyCount4 { get; set; }
        public uint CurrencyCount5 { get; set; }
        public ushort ItemCount1 { get; set; }
        public ushort ItemCount2 { get; set; }
        public ushort ItemCount3 { get; set; }
        public ushort ItemCount4 { get; set; }
        public ushort ItemCount5 { get; set; }
        public ushort RequiredArenaRating { get; set; }
        public ushort CurrencyId1 { get; set; }
        public ushort CurrencyId2 { get; set; }
        public ushort CurrencyId3 { get; set; }
        public ushort CurrencyId4 { get; set; }
        public ushort CurrencyId5 { get; set; }
        public byte ArenaBracket { get; set; }
        public byte MinFactionId { get; set; }
        public byte MinReputation { get; set; }
        public byte Flags { get; set; }
        public byte RequiredAchievement { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
