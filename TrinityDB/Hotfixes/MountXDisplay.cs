using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class MountXDisplay
    {
        public uint Id { get; set; }
        public int CreatureDisplayInfoId { get; set; }
        public uint PlayerConditionId { get; set; }
        public int MountId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
