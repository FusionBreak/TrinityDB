using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class Creature
    {
        public ulong Guid { get; set; }
        public uint Id { get; set; }
        public ushort Map { get; set; }
        public ushort ZoneId { get; set; }
        public ushort AreaId { get; set; }
        public string SpawnDifficulties { get; set; }
        public byte PhaseUseFlags { get; set; }
        public int? PhaseId { get; set; }
        public int? PhaseGroup { get; set; }
        public int TerrainSwapMap { get; set; }
        public uint Modelid { get; set; }
        public sbyte EquipmentId { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public uint Spawntimesecs { get; set; }
        public float Spawndist { get; set; }
        public uint Currentwaypoint { get; set; }
        public uint Curhealth { get; set; }
        public uint Curmana { get; set; }
        public byte MovementType { get; set; }
        public ulong Npcflag { get; set; }
        public uint UnitFlags { get; set; }
        public uint UnitFlags2 { get; set; }
        public uint UnitFlags3 { get; set; }
        public uint Dynamicflags { get; set; }
        public string ScriptName { get; set; }
        public short? VerifiedBuild { get; set; }
        public float Size { get; set; }
    }
}
