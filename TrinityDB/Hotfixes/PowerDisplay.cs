using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class PowerDisplay
    {
        public uint Id { get; set; }
        public string GlobalStringBaseTag { get; set; }
        public byte ActualType { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
