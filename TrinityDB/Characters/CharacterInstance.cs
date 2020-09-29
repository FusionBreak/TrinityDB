using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterInstance
    {
        public ulong Guid { get; set; }
        public uint Instance { get; set; }
        public byte Permanent { get; set; }
        public byte ExtendState { get; set; }
    }
}
