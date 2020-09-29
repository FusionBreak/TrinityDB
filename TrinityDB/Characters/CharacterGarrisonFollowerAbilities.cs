using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterGarrisonFollowerAbilities
    {
        public ulong DbId { get; set; }
        public uint AbilityId { get; set; }
        public byte Slot { get; set; }

        public virtual CharacterGarrisonFollowers Db { get; set; }
    }
}
