using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Phase
    {
        public uint Id { get; set; }
        public ushort Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
