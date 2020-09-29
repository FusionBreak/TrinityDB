using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class RaceUnlockRequirement
    {
        public byte RaceId { get; set; }
        public byte Expansion { get; set; }
        public uint AchievementId { get; set; }
    }
}
