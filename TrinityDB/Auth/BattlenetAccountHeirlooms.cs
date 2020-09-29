using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class BattlenetAccountHeirlooms
    {
        public uint AccountId { get; set; }
        public uint ItemId { get; set; }
        public uint Flags { get; set; }
    }
}
