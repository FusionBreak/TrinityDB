using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GossipMenuOptionAction
    {
        public uint MenuId { get; set; }
        public uint OptionIndex { get; set; }
        public uint ActionMenuId { get; set; }
        public uint ActionPoiId { get; set; }
    }
}
