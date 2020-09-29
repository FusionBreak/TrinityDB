using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GameEventConditionSave
    {
        public byte EventEntry { get; set; }
        public uint ConditionId { get; set; }
        public float? Done { get; set; }
    }
}
