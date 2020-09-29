using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class CreatureTemplate
    {
        public uint Entry { get; set; }
        public uint DifficultyEntry1 { get; set; }
        public uint DifficultyEntry2 { get; set; }
        public uint DifficultyEntry3 { get; set; }
        public uint KillCredit1 { get; set; }
        public uint KillCredit2 { get; set; }
        public uint Modelid1 { get; set; }
        public uint Modelid2 { get; set; }
        public uint Modelid3 { get; set; }
        public uint Modelid4 { get; set; }
        public string Name { get; set; }
        public string FemaleName { get; set; }
        public string Subname { get; set; }
        public string TitleAlt { get; set; }
        public string IconName { get; set; }
        public uint GossipMenuId { get; set; }
        public short Minlevel { get; set; }
        public short Maxlevel { get; set; }
        public int HealthScalingExpansion { get; set; }
        public int RequiredExpansion { get; set; }
        public int VignetteId { get; set; }
        public ushort Faction { get; set; }
        public ulong Npcflag { get; set; }
        public float SpeedWalk { get; set; }
        public float SpeedRun { get; set; }
        public float Scale { get; set; }
        public byte Rank { get; set; }
        public sbyte Dmgschool { get; set; }
        public uint BaseAttackTime { get; set; }
        public uint RangeAttackTime { get; set; }
        public float BaseVariance { get; set; }
        public float RangeVariance { get; set; }
        public byte UnitClass { get; set; }
        public uint UnitFlags { get; set; }
        public uint UnitFlags2 { get; set; }
        public uint UnitFlags3 { get; set; }
        public uint Dynamicflags { get; set; }
        public byte Family { get; set; }
        public byte TrainerClass { get; set; }
        public byte Type { get; set; }
        public uint TypeFlags { get; set; }
        public uint TypeFlags2 { get; set; }
        public uint Lootid { get; set; }
        public uint Pickpocketloot { get; set; }
        public uint Skinloot { get; set; }
        public short Resistance1 { get; set; }
        public short Resistance2 { get; set; }
        public short Resistance3 { get; set; }
        public short Resistance4 { get; set; }
        public short Resistance5 { get; set; }
        public short Resistance6 { get; set; }
        public uint Spell1 { get; set; }
        public uint Spell2 { get; set; }
        public uint Spell3 { get; set; }
        public uint Spell4 { get; set; }
        public uint Spell5 { get; set; }
        public uint Spell6 { get; set; }
        public uint Spell7 { get; set; }
        public uint Spell8 { get; set; }
        public uint VehicleId { get; set; }
        public uint Mingold { get; set; }
        public uint Maxgold { get; set; }
        public string Ainame { get; set; }
        public byte MovementType { get; set; }
        public byte InhabitType { get; set; }
        public float HoverHeight { get; set; }
        public float HealthModifier { get; set; }
        public float HealthModifierExtra { get; set; }
        public float ManaModifier { get; set; }
        public float ManaModifierExtra { get; set; }
        public float ArmorModifier { get; set; }
        public float DamageModifier { get; set; }
        public float ExperienceModifier { get; set; }
        public byte RacialLeader { get; set; }
        public uint MovementId { get; set; }
        public byte RegenHealth { get; set; }
        public uint MechanicImmuneMask { get; set; }
        public uint FlagsExtra { get; set; }
        public string ScriptName { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
