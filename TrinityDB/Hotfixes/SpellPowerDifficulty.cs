using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellPowerDifficulty
    {
        public byte DifficultyId { get; set; }
        public byte OrderIndex { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
