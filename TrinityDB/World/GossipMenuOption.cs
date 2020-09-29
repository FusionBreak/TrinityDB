using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GossipMenuOption
    {
        public uint MenuId { get; set; }
        public uint OptionIndex { get; set; }
        public byte OptionIcon { get; set; }
        public string OptionText { get; set; }
        public uint OptionBroadcastTextId { get; set; }
        public uint OptionType { get; set; }
        public ulong OptionNpcFlag { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
