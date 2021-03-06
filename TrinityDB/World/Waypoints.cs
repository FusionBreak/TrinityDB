﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class Waypoints
    {
        public uint Entry { get; set; }
        public uint Pointid { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public string PointComment { get; set; }
    }
}
