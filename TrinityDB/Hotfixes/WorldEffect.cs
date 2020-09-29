using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class WorldEffect
    {
        public uint Id { get; set; }
        public int TargetAsset { get; set; }
        public ushort CombatConditionId { get; set; }
        public byte TargetType { get; set; }
        public byte WhenToDisplay { get; set; }
        public uint QuestFeedbackEffectId { get; set; }
        public uint PlayerConditionId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
