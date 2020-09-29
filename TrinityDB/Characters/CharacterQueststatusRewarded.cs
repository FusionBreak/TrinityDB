using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterQueststatusRewarded
    {
        public ulong Guid { get; set; }
        public uint Quest { get; set; }
        public byte Active { get; set; }
    }
}
