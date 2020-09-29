using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpellTargetPosition
    {
        public uint Id { get; set; }
        public byte EffectIndex { get; set; }
        public ushort MapId { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
