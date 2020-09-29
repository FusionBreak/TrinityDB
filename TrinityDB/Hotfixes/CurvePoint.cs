using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CurvePoint
    {
        public uint Id { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public ushort CurveId { get; set; }
        public byte OrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
