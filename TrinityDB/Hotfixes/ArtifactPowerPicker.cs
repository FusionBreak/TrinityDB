using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArtifactPowerPicker
    {
        public uint Id { get; set; }
        public uint PlayerConditionId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
