using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class AnimKit
    {
        public uint Id { get; set; }
        public uint OneShotDuration { get; set; }
        public ushort OneShotStopAnimKitId { get; set; }
        public ushort LowDefAnimKitId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
