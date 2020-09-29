using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellTotems
    {
        public uint Id { get; set; }
        public int SpellId { get; set; }
        public int Totem1 { get; set; }
        public int Totem2 { get; set; }
        public ushort RequiredTotemCategoryId1 { get; set; }
        public ushort RequiredTotemCategoryId2 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
