﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class Disables
    {
        public uint SourceType { get; set; }
        public uint Entry { get; set; }
        public byte Flags { get; set; }
        public string Params0 { get; set; }
        public string Params1 { get; set; }
        public string Comment { get; set; }
    }
}
