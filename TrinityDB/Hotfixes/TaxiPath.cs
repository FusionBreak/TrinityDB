using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class TaxiPath
    {
        public ushort FromTaxiNode { get; set; }
        public ushort ToTaxiNode { get; set; }
        public uint Id { get; set; }
        public uint Cost { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
