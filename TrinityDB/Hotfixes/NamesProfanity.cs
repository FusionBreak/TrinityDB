using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class NamesProfanity
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public sbyte Language { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
