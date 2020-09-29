using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class QuestVisualEffect
    {
        public uint Id { get; set; }
        public byte Index { get; set; }
        public int VisualEffect { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
