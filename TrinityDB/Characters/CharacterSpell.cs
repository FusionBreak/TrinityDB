using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterSpell
    {
        public ulong Guid { get; set; }
        public uint Spell { get; set; }
        public byte Active { get; set; }
        public byte Disabled { get; set; }
    }
}
