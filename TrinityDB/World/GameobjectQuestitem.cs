﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GameobjectQuestitem
    {
        public uint GameObjectEntry { get; set; }
        public uint Idx { get; set; }
        public uint ItemId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
