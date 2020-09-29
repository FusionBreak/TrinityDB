using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class ScriptSplineChainMeta
    {
        public uint Entry { get; set; }
        public ushort ChainId { get; set; }
        public byte SplineId { get; set; }
        public uint ExpectedDuration { get; set; }
        public uint MsUntilNext { get; set; }
    }
}
