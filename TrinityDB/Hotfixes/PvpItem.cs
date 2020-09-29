using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class PvpItem
    {
        public uint Id { get; set; }
        public int ItemId { get; set; }
        public byte ItemLevelDelta { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
