using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class AreatriggerTemplatePolygonVertices
    {
        public uint AreaTriggerId { get; set; }
        public uint Idx { get; set; }
        public float VerticeX { get; set; }
        public float VerticeY { get; set; }
        public float? VerticeTargetX { get; set; }
        public float? VerticeTargetY { get; set; }
        public uint VerifiedBuild { get; set; }
    }
}
