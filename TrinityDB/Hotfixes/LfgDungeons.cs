using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class LfgDungeons
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }
        public float MinGear { get; set; }
        public ushort MaxLevel { get; set; }
        public ushort TargetLevelMax { get; set; }
        public short MapId { get; set; }
        public ushort RandomId { get; set; }
        public ushort ScenarioId { get; set; }
        public ushort FinalEncounterId { get; set; }
        public ushort BonusReputationAmount { get; set; }
        public ushort MentorItemLevel { get; set; }
        public ushort RequiredPlayerConditionId { get; set; }
        public byte MinLevel { get; set; }
        public byte TargetLevel { get; set; }
        public byte TargetLevelMin { get; set; }
        public byte DifficultyId { get; set; }
        public byte TypeId { get; set; }
        public sbyte Faction { get; set; }
        public byte ExpansionLevel { get; set; }
        public byte OrderIndex { get; set; }
        public byte GroupId { get; set; }
        public byte CountTank { get; set; }
        public byte CountHealer { get; set; }
        public byte CountDamage { get; set; }
        public byte MinCountTank { get; set; }
        public byte MinCountHealer { get; set; }
        public byte MinCountDamage { get; set; }
        public byte Subtype { get; set; }
        public byte MentorCharLevel { get; set; }
        public int IconTextureFileId { get; set; }
        public int RewardsBgTextureFileId { get; set; }
        public int PopupBgTextureFileId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
