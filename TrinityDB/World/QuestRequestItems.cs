using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class QuestRequestItems
    {
        public uint Id { get; set; }
        public ushort EmoteOnComplete { get; set; }
        public ushort EmoteOnIncomplete { get; set; }
        public uint EmoteOnCompleteDelay { get; set; }
        public uint EmoteOnIncompleteDelay { get; set; }
        public string CompletionText { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
