using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class WorldSafeLocs
    {
        public uint Id { get; set; }
        public string AreaName { get; set; }
        public float LocX { get; set; }
        public float LocY { get; set; }
        public float LocZ { get; set; }
        public float Facing { get; set; }
        public ushort MapId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
