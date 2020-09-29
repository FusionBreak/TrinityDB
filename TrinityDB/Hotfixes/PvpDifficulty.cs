using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class PvpDifficulty
    {
        public uint Id { get; set; }
        public byte RangeIndex { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public ushort MapId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
