using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CreatureType
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
