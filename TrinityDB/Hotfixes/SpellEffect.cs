﻿using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellEffect
    {
        public uint Id { get; set; }
        public uint Effect { get; set; }
        public int EffectBasePoints { get; set; }
        public int EffectIndex { get; set; }
        public int EffectAura { get; set; }
        public int DifficultyId { get; set; }
        public float EffectAmplitude { get; set; }
        public int EffectAuraPeriod { get; set; }
        public float EffectBonusCoefficient { get; set; }
        public float EffectChainAmplitude { get; set; }
        public int EffectChainTargets { get; set; }
        public int EffectDieSides { get; set; }
        public int EffectItemType { get; set; }
        public int EffectMechanic { get; set; }
        public float EffectPointsPerResource { get; set; }
        public float EffectRealPointsPerLevel { get; set; }
        public int EffectTriggerSpell { get; set; }
        public float EffectPosFacing { get; set; }
        public int EffectAttributes { get; set; }
        public float BonusCoefficientFromAp { get; set; }
        public float PvpMultiplier { get; set; }
        public float Coefficient { get; set; }
        public float Variance { get; set; }
        public float ResourceCoefficient { get; set; }
        public float GroupSizeBasePointsCoefficient { get; set; }
        public uint EffectSpellClassMask1 { get; set; }
        public uint EffectSpellClassMask2 { get; set; }
        public uint EffectSpellClassMask3 { get; set; }
        public uint EffectSpellClassMask4 { get; set; }
        public int EffectMiscValue1 { get; set; }
        public int EffectMiscValue2 { get; set; }
        public uint EffectRadiusIndex1 { get; set; }
        public uint EffectRadiusIndex2 { get; set; }
        public uint ImplicitTarget1 { get; set; }
        public uint ImplicitTarget2 { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
