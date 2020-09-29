using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class PlayerchoiceResponseReward
    {
        public int ChoiceId { get; set; }
        public int ResponseId { get; set; }
        public int TitleId { get; set; }
        public int PackageId { get; set; }
        public uint SkillLineId { get; set; }
        public uint SkillPointCount { get; set; }
        public uint ArenaPointCount { get; set; }
        public uint HonorPointCount { get; set; }
        public ulong Money { get; set; }
        public uint Xp { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
