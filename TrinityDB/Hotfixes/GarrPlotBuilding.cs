using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrPlotBuilding
    {
        public uint Id { get; set; }
        public byte GarrPlotId { get; set; }
        public byte GarrBuildingId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
