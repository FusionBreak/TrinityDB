using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterSocial
    {
        public ulong Guid { get; set; }
        public ulong Friend { get; set; }
        public byte Flags { get; set; }
        public string Note { get; set; }
    }
}
