using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArtifactPowerLink
    {
        public uint Id { get; set; }
        public ushort PowerA { get; set; }
        public ushort PowerB { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
