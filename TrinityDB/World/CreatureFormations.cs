using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CreatureFormations
    {
        public ulong LeaderGuid { get; set; }
        public ulong MemberGuid { get; set; }
        public float Dist { get; set; }
        public float Angle { get; set; }
        public uint GroupAi { get; set; }
        public ushort Point1 { get; set; }
        public ushort Point2 { get; set; }
    }
}
