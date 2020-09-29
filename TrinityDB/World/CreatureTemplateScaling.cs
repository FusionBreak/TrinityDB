using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CreatureTemplateScaling
    {
        public uint Entry { get; set; }
        public ushort LevelScalingMin { get; set; }
        public ushort LevelScalingMax { get; set; }
        public short LevelScalingDeltaMin { get; set; }
        public short LevelScalingDeltaMax { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
