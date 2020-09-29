using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class PetSpellCharges
    {
        public uint Guid { get; set; }
        public uint CategoryId { get; set; }
        public uint RechargeStart { get; set; }
        public uint RechargeEnd { get; set; }
    }
}
