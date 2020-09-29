using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GarrPlot
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int AllianceConstructObjId { get; set; }
        public int HordeConstructObjId { get; set; }
        public byte UiCategoryId { get; set; }
        public byte PlotType { get; set; }
        public byte Flags { get; set; }
        public uint UpgradeRequirement1 { get; set; }
        public uint UpgradeRequirement2 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
