using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class PlayercreateinfoItem
    {
        public byte Race { get; set; }
        public byte Class { get; set; }
        public uint Itemid { get; set; }
        public sbyte Amount { get; set; }
    }
}
