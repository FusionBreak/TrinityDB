using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrPlotInstance
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public byte GarrPlotId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
