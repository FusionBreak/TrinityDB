using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GuildColorBorder
    {
        public uint Id { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
