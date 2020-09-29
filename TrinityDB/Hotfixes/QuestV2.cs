using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class QuestV2
    {
        public uint Id { get; set; }
        public ushort UniqueBitFlag { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
