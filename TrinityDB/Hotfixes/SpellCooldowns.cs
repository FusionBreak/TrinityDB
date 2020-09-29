using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellCooldowns
    {
        public uint Id { get; set; }
        public int CategoryRecoveryTime { get; set; }
        public int RecoveryTime { get; set; }
        public int StartRecoveryTime { get; set; }
        public byte DifficultyId { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
