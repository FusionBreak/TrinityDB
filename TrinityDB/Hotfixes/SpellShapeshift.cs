using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellShapeshift
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public int ShapeshiftExclude1 { get; set; }
        public int ShapeshiftExclude2 { get; set; }
        public int ShapeshiftMask1 { get; set; }
        public int ShapeshiftMask2 { get; set; }
        public sbyte StanceBarOrder { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
