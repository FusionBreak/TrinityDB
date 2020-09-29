using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellRadius
    {
        public uint Id { get; set; }
        public float Radius { get; set; }
        public float RadiusPerLevel { get; set; }
        public float RadiusMin { get; set; }
        public float RadiusMax { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
