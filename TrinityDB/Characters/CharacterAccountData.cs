using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterAccountData
    {
        public ulong Guid { get; set; }
        public byte Type { get; set; }
        public uint Time { get; set; }
        public byte[] Data { get; set; }
    }
}
