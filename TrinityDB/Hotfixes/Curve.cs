using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Curve
    {
        public uint Id { get; set; }
        public byte Type { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
