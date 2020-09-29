using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class TotemCategory
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public int TotemCategoryMask { get; set; }
        public byte TotemCategoryType { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
