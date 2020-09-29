using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class ScenarioPoiPoints
    {
        public int CriteriaTreeId { get; set; }
        public int Idx1 { get; set; }
        public int Idx2 { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
