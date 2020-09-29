using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterSkills
    {
        public ulong Guid { get; set; }
        public ushort Skill { get; set; }
        public ushort Value { get; set; }
        public ushort Max { get; set; }
    }
}
