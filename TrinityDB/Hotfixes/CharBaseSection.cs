using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CharBaseSection
    {
        public uint Id { get; set; }
        public byte VariationEnum { get; set; }
        public byte ResolutionVariationEnum { get; set; }
        public byte LayoutResType { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
