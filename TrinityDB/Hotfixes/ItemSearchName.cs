using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class ItemSearchName
    {
        public long AllowableRace { get; set; }
        public string Display { get; set; }
        public uint Id { get; set; }
        public int Flags1 { get; set; }
        public int Flags2 { get; set; }
        public int Flags3 { get; set; }
        public ushort ItemLevel { get; set; }
        public byte OverallQualityId { get; set; }
        public byte ExpansionId { get; set; }
        public sbyte RequiredLevel { get; set; }
        public ushort MinFactionId { get; set; }
        public byte MinReputation { get; set; }
        public int AllowableClass { get; set; }
        public ushort RequiredSkill { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public uint RequiredAbility { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
