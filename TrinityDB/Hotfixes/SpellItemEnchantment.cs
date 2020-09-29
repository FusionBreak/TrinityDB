using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellItemEnchantment
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public uint EffectArg1 { get; set; }
        public uint EffectArg2 { get; set; }
        public uint EffectArg3 { get; set; }
        public float EffectScalingPoints1 { get; set; }
        public float EffectScalingPoints2 { get; set; }
        public float EffectScalingPoints3 { get; set; }
        public uint TransmogCost { get; set; }
        public uint IconFileDataId { get; set; }
        public short EffectPointsMin1 { get; set; }
        public short EffectPointsMin2 { get; set; }
        public short EffectPointsMin3 { get; set; }
        public ushort ItemVisual { get; set; }
        public ushort Flags { get; set; }
        public ushort RequiredSkillId { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public ushort ItemLevel { get; set; }
        public byte Charges { get; set; }
        public byte Effect1 { get; set; }
        public byte Effect2 { get; set; }
        public byte Effect3 { get; set; }
        public byte ConditionId { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public sbyte ScalingClass { get; set; }
        public sbyte ScalingClassRestricted { get; set; }
        public uint TransmogPlayerConditionId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
