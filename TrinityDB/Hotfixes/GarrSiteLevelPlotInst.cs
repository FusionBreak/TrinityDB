using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrSiteLevelPlotInst
    {
        public uint Id { get; set; }
        public float UiMarkerPosX { get; set; }
        public float UiMarkerPosY { get; set; }
        public ushort GarrSiteLevelId { get; set; }
        public byte GarrPlotInstanceId { get; set; }
        public byte UiMarkerSize { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
