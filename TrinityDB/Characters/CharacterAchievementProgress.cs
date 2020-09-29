using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterAchievementProgress
    {
        public ulong Guid { get; set; }
        public uint Criteria { get; set; }
        public ulong Counter { get; set; }
        public uint Date { get; set; }
    }
}
