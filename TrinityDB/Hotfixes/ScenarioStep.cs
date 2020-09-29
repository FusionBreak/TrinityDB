using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ScenarioStep
    {
        public uint Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public ushort ScenarioId { get; set; }
        public ushort Supersedes { get; set; }
        public ushort RewardQuestId { get; set; }
        public byte OrderIndex { get; set; }
        public byte Flags { get; set; }
        public uint Criteriatreeid { get; set; }
        public int RelatedStep { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
