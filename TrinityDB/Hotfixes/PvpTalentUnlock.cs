using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class PvpTalentUnlock
    {
        public uint Id { get; set; }
        public int TierId { get; set; }
        public int ColumnIndex { get; set; }
        public int HonorLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
