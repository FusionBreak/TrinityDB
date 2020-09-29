using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellLevels
    {
        public uint Id { get; set; }
        public short BaseLevel { get; set; }
        public short MaxLevel { get; set; }
        public short SpellLevel { get; set; }
        public byte DifficultyId { get; set; }
        public byte MaxPassiveAuraLevel { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
