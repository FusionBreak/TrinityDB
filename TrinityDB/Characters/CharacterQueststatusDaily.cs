using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterQueststatusDaily
    {
        public ulong Guid { get; set; }
        public uint Quest { get; set; }
        public uint Time { get; set; }
    }
}
