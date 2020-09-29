using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class QuestObjectives
    {
        public uint Id { get; set; }
        public uint QuestId { get; set; }
        public byte Type { get; set; }
        public byte Order { get; set; }
        public sbyte StorageIndex { get; set; }
        public int ObjectId { get; set; }
        public int Amount { get; set; }
        public uint Flags { get; set; }
        public uint Flags2 { get; set; }
        public float ProgressBarWeight { get; set; }
        public string Description { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
