using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class PvpReward
    {
        public uint Id { get; set; }
        public int HonorLevel { get; set; }
        public int PrestigeLevel { get; set; }
        public int RewardPackId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
