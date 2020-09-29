using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GossipMenuOptionBox
    {
        public uint MenuId { get; set; }
        public uint OptionIndex { get; set; }
        public byte BoxCoded { get; set; }
        public uint BoxMoney { get; set; }
        public string BoxText { get; set; }
        public uint BoxBroadcastTextId { get; set; }
    }
}
