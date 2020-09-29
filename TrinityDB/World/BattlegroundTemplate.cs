using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class BattlegroundTemplate
    {
        public uint Id { get; set; }
        public ushort MinPlayersPerTeam { get; set; }
        public ushort MaxPlayersPerTeam { get; set; }
        public byte MinLvl { get; set; }
        public byte MaxLvl { get; set; }
        public uint AllianceStartLoc { get; set; }
        public uint HordeStartLoc { get; set; }
        public float StartMaxDist { get; set; }
        public byte Weight { get; set; }
        public string ScriptName { get; set; }
        public string Comment { get; set; }
    }
}
