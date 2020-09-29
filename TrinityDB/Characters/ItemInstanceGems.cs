using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class ItemInstanceGems
    {
        public ulong ItemGuid { get; set; }
        public uint GemItemId1 { get; set; }
        public string GemBonuses1 { get; set; }
        public byte GemContext1 { get; set; }
        public uint GemScalingLevel1 { get; set; }
        public uint GemItemId2 { get; set; }
        public string GemBonuses2 { get; set; }
        public byte GemContext2 { get; set; }
        public uint GemScalingLevel2 { get; set; }
        public uint GemItemId3 { get; set; }
        public string GemBonuses3 { get; set; }
        public byte GemContext3 { get; set; }
        public uint GemScalingLevel3 { get; set; }
    }
}
