using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GuildAchievementProgress
    {
        public ulong GuildId { get; set; }
        public uint Criteria { get; set; }
        public ulong Counter { get; set; }
        public uint Date { get; set; }
        public ulong CompletedGuid { get; set; }
    }
}
