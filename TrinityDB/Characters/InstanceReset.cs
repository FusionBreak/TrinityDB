﻿using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class InstanceReset
    {
        public ushort Mapid { get; set; }
        public byte Difficulty { get; set; }
        public uint Resettime { get; set; }
    }
}
