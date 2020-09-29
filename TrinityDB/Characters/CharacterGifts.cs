using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterGifts
    {
        public ulong Guid { get; set; }
        public ulong ItemGuid { get; set; }
        public uint Entry { get; set; }
        public uint Flags { get; set; }
    }
}
