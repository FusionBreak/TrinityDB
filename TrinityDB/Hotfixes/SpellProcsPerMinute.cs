﻿using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellProcsPerMinute
    {
        public uint Id { get; set; }
        public float BaseProcRate { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
