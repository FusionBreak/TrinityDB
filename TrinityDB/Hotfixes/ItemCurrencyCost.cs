using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemCurrencyCost
    {
        public uint Id { get; set; }
        public int ItemId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
