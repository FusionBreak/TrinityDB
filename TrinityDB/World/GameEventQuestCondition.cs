﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GameEventQuestCondition
    {
        public byte EventEntry { get; set; }
        public uint Quest { get; set; }
        public uint ConditionId { get; set; }
        public float? Num { get; set; }
    }
}
