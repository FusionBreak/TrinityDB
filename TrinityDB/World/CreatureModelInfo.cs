using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CreatureModelInfo
    {
        public uint DisplayId { get; set; }
        public float BoundingRadius { get; set; }
        public float CombatReach { get; set; }
        public uint DisplayIdOtherGender { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
