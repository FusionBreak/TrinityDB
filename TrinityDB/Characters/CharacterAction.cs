using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterAction
    {
        public ulong Guid { get; set; }
        public byte Spec { get; set; }
        public byte Button { get; set; }
        public uint Action { get; set; }
        public byte Type { get; set; }
    }
}
