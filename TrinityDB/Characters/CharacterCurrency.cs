using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterCurrency
    {
        public ulong CharacterGuid { get; set; }
        public ushort Currency { get; set; }
        public uint Quantity { get; set; }
        public uint WeeklyQuantity { get; set; }
        public uint TrackedQuantity { get; set; }
        public byte Flags { get; set; }
    }
}
