using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterVoidStorage
    {
        public ulong ItemId { get; set; }
        public ulong PlayerGuid { get; set; }
        public uint ItemEntry { get; set; }
        public byte Slot { get; set; }
        public ulong CreatorGuid { get; set; }
        public byte RandomPropertyType { get; set; }
        public uint RandomProperty { get; set; }
        public uint SuffixFactor { get; set; }
        public uint UpgradeId { get; set; }
        public uint? FixedScalingLevel { get; set; }
        public uint? ArtifactKnowledgeLevel { get; set; }
        public byte Context { get; set; }
        public string BonusListIds { get; set; }
    }
}
