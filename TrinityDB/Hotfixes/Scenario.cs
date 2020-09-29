using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Scenario
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public ushort AreaTableId { get; set; }
        public byte Flags { get; set; }
        public byte Type { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
