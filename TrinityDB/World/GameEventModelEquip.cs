using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GameEventModelEquip
    {
        public sbyte EventEntry { get; set; }
        public ulong Guid { get; set; }
        public uint Modelid { get; set; }
        public byte EquipmentId { get; set; }
    }
}
