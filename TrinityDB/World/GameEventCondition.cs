﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GameEventCondition
    {
        public byte EventEntry { get; set; }
        public uint ConditionId { get; set; }
        public float? ReqNum { get; set; }
        public ushort MaxWorldStateField { get; set; }
        public ushort DoneWorldStateField { get; set; }
        public string Description { get; set; }
    }
}
