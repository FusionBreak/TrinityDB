using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpellAreatriggerCircular
    {
        public uint SpellMiscId { get; set; }
        public uint StartDelay { get; set; }
        public float CircleRadius { get; set; }
        public float BlendFromRadius { get; set; }
        public float InitialAngle { get; set; }
        public float Zoffset { get; set; }
        public byte CounterClockwise { get; set; }
        public byte CanLoop { get; set; }
        public uint VerifiedBuild { get; set; }
    }
}
