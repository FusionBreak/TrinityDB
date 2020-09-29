using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ImportPriceQuality
    {
        public uint Id { get; set; }
        public float Data { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
