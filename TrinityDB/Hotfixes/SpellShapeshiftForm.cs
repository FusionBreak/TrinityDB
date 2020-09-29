using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class SpellShapeshiftForm
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public float DamageVariance { get; set; }
        public int Flags { get; set; }
        public short CombatRoundTime { get; set; }
        public ushort MountTypeId { get; set; }
        public sbyte CreatureType { get; set; }
        public sbyte BonusActionBar { get; set; }
        public int AttackIconFileId { get; set; }
        public uint CreatureDisplayId1 { get; set; }
        public uint CreatureDisplayId2 { get; set; }
        public uint CreatureDisplayId3 { get; set; }
        public uint CreatureDisplayId4 { get; set; }
        public uint PresetSpellId1 { get; set; }
        public uint PresetSpellId2 { get; set; }
        public uint PresetSpellId3 { get; set; }
        public uint PresetSpellId4 { get; set; }
        public uint PresetSpellId5 { get; set; }
        public uint PresetSpellId6 { get; set; }
        public uint PresetSpellId7 { get; set; }
        public uint PresetSpellId8 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
