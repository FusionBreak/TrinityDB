﻿using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class VehicleTemplateAccessory
    {
        public uint Entry { get; set; }
        public uint AccessoryEntry { get; set; }
        public sbyte SeatId { get; set; }
        public byte Minion { get; set; }
        public string Description { get; set; }
        public byte Summontype { get; set; }
        public uint Summontimer { get; set; }
    }
}
