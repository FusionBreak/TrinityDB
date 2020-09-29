using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemBonusListLevelDelta
    {
        public short ItemLevelDelta { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
