using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Spell
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string NameSubtext { get; set; }
        public string Description { get; set; }
        public string AuraDescription { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
