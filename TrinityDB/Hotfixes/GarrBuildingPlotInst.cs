using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrBuildingPlotInst
    {
        public float MapOffsetX { get; set; }
        public float MapOffsetY { get; set; }
        public ushort UiTextureAtlasMemberId { get; set; }
        public ushort GarrSiteLevelPlotInstId { get; set; }
        public byte GarrBuildingId { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
