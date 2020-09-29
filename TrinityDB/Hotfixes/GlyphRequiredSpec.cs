using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class GlyphRequiredSpec
    {
        public uint Id { get; set; }
        public ushort ChrSpecializationId { get; set; }
        public ushort GlyphPropertiesId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
