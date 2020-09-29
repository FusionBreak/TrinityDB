using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ArmorLocation
    {
        public uint Id { get; set; }
        public float Clothmodifier { get; set; }
        public float Leathermodifier { get; set; }
        public float Chainmodifier { get; set; }
        public float Platemodifier { get; set; }
        public float Modifier { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
