using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class ItemInstanceModifiers
    {
        public ulong ItemGuid { get; set; }
        public uint? FixedScalingLevel { get; set; }
        public uint? ArtifactKnowledgeLevel { get; set; }
    }
}
