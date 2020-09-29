using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class BattlePetSlots
    {
        public sbyte Id { get; set; }
        public int BattlenetAccountId { get; set; }
        public long BattlePetGuid { get; set; }
        public sbyte Locked { get; set; }
    }
}
