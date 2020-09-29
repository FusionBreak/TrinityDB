using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArtifactCategory
    {
        public uint Id { get; set; }
        public short XpMultCurrencyId { get; set; }
        public short XpMultCurveId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
