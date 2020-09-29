using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class PhaseXPhaseGroup
    {
        public uint Id { get; set; }
        public ushort PhaseId { get; set; }
        public ushort PhaseGroupId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
