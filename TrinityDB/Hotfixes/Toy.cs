using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Toy
    {
        public string SourceText { get; set; }
        public int ItemId { get; set; }
        public byte Flags { get; set; }
        public sbyte SourceTypeEnum { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
