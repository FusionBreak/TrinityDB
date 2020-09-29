using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SkillLineAbility
    {
        public long RaceMask { get; set; }
        public uint Id { get; set; }
        public int Spell { get; set; }
        public int SupercedesSpell { get; set; }
        public short SkillLine { get; set; }
        public short TrivialSkillLineRankHigh { get; set; }
        public short TrivialSkillLineRankLow { get; set; }
        public short UniqueBit { get; set; }
        public short TradeSkillCategoryId { get; set; }
        public sbyte NumSkillUps { get; set; }
        public int ClassMask { get; set; }
        public short MinSkillLineRank { get; set; }
        public sbyte AcquireMethod { get; set; }
        public sbyte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
