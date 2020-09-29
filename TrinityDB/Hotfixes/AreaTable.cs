using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class AreaTable
    {
        public uint Id { get; set; }
        public string ZoneName { get; set; }
        public string AreaName { get; set; }
        public int Flags1 { get; set; }
        public int Flags2 { get; set; }
        public float AmbientMultiplier { get; set; }
        public ushort ContinentId { get; set; }
        public ushort ParentAreaId { get; set; }
        public short AreaBit { get; set; }
        public ushort AmbienceId { get; set; }
        public ushort ZoneMusic { get; set; }
        public ushort IntroSound { get; set; }
        public ushort LiquidTypeId1 { get; set; }
        public ushort LiquidTypeId2 { get; set; }
        public ushort LiquidTypeId3 { get; set; }
        public ushort LiquidTypeId4 { get; set; }
        public ushort UwZoneMusic { get; set; }
        public ushort UwAmbience { get; set; }
        public short PvpCombatWorldStateId { get; set; }
        public byte SoundProviderPref { get; set; }
        public byte SoundProviderPrefUnderwater { get; set; }
        public sbyte ExplorationLevel { get; set; }
        public byte FactionGroupMask { get; set; }
        public byte MountFlags { get; set; }
        public byte WildBattlePetLevelMin { get; set; }
        public byte WildBattlePetLevelMax { get; set; }
        public byte WindSettingsId { get; set; }
        public uint UwIntroSound { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
