using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterSpellCooldown
    {
        public ulong Guid { get; set; }
        public uint Spell { get; set; }
        public uint Item { get; set; }
        public uint Time { get; set; }
        public uint CategoryId { get; set; }
        public uint CategoryEnd { get; set; }
    }
}
