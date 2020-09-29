using System;
using System.Collections.Generic;

namespace TrinityDB.Auth
{
    public partial class BattlenetAccountToys
    {
        public uint AccountId { get; set; }
        public int ItemId { get; set; }
        public bool? IsFavourite { get; set; }
    }
}
