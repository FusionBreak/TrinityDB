using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class ItemLootItems
    {
        public ulong ContainerId { get; set; }
        public uint ItemId { get; set; }
        public int ItemCount { get; set; }
        public bool FollowRules { get; set; }
        public bool Ffa { get; set; }
        public bool Blocked { get; set; }
        public bool Counted { get; set; }
        public bool UnderThreshold { get; set; }
        public bool NeedsQuest { get; set; }
        public byte RndType { get; set; }
        public uint RndProp { get; set; }
        public int RndSuffix { get; set; }
        public byte Context { get; set; }
        public string BonusListIds { get; set; }
    }
}
