using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterQueststatusObjectives
    {
        public ulong Guid { get; set; }
        public uint Quest { get; set; }
        public byte Objective { get; set; }
        public int Data { get; set; }
    }
}
