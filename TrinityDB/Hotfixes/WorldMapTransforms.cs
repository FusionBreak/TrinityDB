using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class WorldMapTransforms
    {
        public uint Id { get; set; }
        public float RegionMinX { get; set; }
        public float RegionMinY { get; set; }
        public float RegionMinZ { get; set; }
        public float RegionMaxX { get; set; }
        public float RegionMaxY { get; set; }
        public float RegionMaxZ { get; set; }
        public float RegionOffsetX { get; set; }
        public float RegionOffsetY { get; set; }
        public float RegionScale { get; set; }
        public ushort MapId { get; set; }
        public ushort AreaId { get; set; }
        public ushort NewMapId { get; set; }
        public ushort NewDungeonMapId { get; set; }
        public ushort NewAreaId { get; set; }
        public byte Flags { get; set; }
        public int Priority { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
