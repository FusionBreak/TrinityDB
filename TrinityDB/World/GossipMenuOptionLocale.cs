using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GossipMenuOptionLocale
    {
        public uint MenuId { get; set; }
        public uint OptionIndex { get; set; }
        public string Locale { get; set; }
        public string OptionText { get; set; }
        public string BoxText { get; set; }
    }
}
