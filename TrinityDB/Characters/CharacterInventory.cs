using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterInventory
    {
        public ulong Guid { get; set; }
        public ulong Bag { get; set; }
        public byte Slot { get; set; }
        public ulong Item { get; set; }
    }
}
