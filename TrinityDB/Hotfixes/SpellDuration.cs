using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellDuration
    {
        public uint Id { get; set; }
        public int Duration { get; set; }
        public int MaxDuration { get; set; }
        public uint DurationPerLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
