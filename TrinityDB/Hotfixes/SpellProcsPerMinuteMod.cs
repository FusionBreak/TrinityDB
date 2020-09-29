using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellProcsPerMinuteMod
    {
        public uint Id { get; set; }
        public float Coeff { get; set; }
        public short Param { get; set; }
        public byte Type { get; set; }
        public ushort SpellProcsPerMinuteId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
