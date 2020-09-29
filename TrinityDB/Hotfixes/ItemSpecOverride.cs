using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemSpecOverride
    {
        public uint Id { get; set; }
        public ushort SpecId { get; set; }
        public int ItemId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
