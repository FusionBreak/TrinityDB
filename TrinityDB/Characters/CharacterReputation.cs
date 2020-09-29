using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterReputation
    {
        public ulong Guid { get; set; }
        public ushort Faction { get; set; }
        public int Standing { get; set; }
        public ushort Flags { get; set; }
    }
}
