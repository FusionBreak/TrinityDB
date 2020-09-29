using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterQueststatus
    {
        public ulong Guid { get; set; }
        public uint Quest { get; set; }
        public byte Status { get; set; }
        public uint Timer { get; set; }
    }
}
