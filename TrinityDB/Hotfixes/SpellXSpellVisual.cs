using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellXSpellVisual
    {
        public uint SpellVisualId { get; set; }
        public uint Id { get; set; }
        public float Probability { get; set; }
        public ushort CasterPlayerConditionId { get; set; }
        public ushort CasterUnitConditionId { get; set; }
        public ushort ViewerPlayerConditionId { get; set; }
        public ushort ViewerUnitConditionId { get; set; }
        public int SpellIconFileId { get; set; }
        public int ActiveIconFileId { get; set; }
        public byte Flags { get; set; }
        public byte DifficultyId { get; set; }
        public byte Priority { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
