using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class ItemRefundInstance
    {
        public ulong ItemGuid { get; set; }
        public ulong PlayerGuid { get; set; }
        public ulong PaidMoney { get; set; }
        public ushort PaidExtendedCost { get; set; }
    }
}
