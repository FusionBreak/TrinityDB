using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class Groups
    {
        public uint Guid { get; set; }
        public ulong LeaderGuid { get; set; }
        public byte LootMethod { get; set; }
        public ulong LooterGuid { get; set; }
        public byte LootThreshold { get; set; }
        public byte[] Icon1 { get; set; }
        public byte[] Icon2 { get; set; }
        public byte[] Icon3 { get; set; }
        public byte[] Icon4 { get; set; }
        public byte[] Icon5 { get; set; }
        public byte[] Icon6 { get; set; }
        public byte[] Icon7 { get; set; }
        public byte[] Icon8 { get; set; }
        public byte GroupType { get; set; }
        public byte Difficulty { get; set; }
        public byte RaidDifficulty { get; set; }
        public byte LegacyRaidDifficulty { get; set; }
        public ulong MasterLooterGuid { get; set; }
    }
}
