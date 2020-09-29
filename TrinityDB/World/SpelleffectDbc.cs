using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class SpelleffectDbc
    {
        public uint Id { get; set; }
        public uint Effect { get; set; }
        public float EffectValueMultiplier { get; set; }
        public uint EffectApplyAuraName { get; set; }
        public uint EffectAmplitude { get; set; }
        public int EffectBasePoints { get; set; }
        public float EffectBonusMultiplier { get; set; }
        public float EffectDamageMultiplier { get; set; }
        public uint EffectChainTarget { get; set; }
        public int EffectDieSides { get; set; }
        public uint EffectItemType { get; set; }
        public uint EffectMechanic { get; set; }
        public int EffectMiscValue { get; set; }
        public int EffectMiscValueB { get; set; }
        public uint EffectRadiusIndex { get; set; }
        public uint EffectRadiusIndexMax { get; set; }
        public float EffectRealPointsPerLevel { get; set; }
        public uint EffectSpellClassMaskA { get; set; }
        public uint EffectSpellClassMaskB { get; set; }
        public uint EffectSpellClassMaskC { get; set; }
        public uint EffectTriggerSpell { get; set; }
        public uint EffectImplicitTargetA { get; set; }
        public uint EffectImplicitTargetB { get; set; }
        public uint EffectSpellId { get; set; }
        public uint EffectIndex { get; set; }
    }
}
