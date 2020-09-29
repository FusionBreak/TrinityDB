using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterSpellCharges
    {
        public ulong Guid { get; set; }
        public uint CategoryId { get; set; }
        public uint RechargeStart { get; set; }
        public uint RechargeEnd { get; set; }
    }
}
