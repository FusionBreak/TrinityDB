using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CharTitles
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Name1 { get; set; }
        public short MaskId { get; set; }
        public sbyte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
