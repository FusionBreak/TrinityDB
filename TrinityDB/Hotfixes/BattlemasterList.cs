using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class BattlemasterList
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string GameType { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int IconFileDataId { get; set; }
        public short MapId1 { get; set; }
        public short MapId2 { get; set; }
        public short MapId3 { get; set; }
        public short MapId4 { get; set; }
        public short MapId5 { get; set; }
        public short MapId6 { get; set; }
        public short MapId7 { get; set; }
        public short MapId8 { get; set; }
        public short MapId9 { get; set; }
        public short MapId10 { get; set; }
        public short MapId11 { get; set; }
        public short MapId12 { get; set; }
        public short MapId13 { get; set; }
        public short MapId14 { get; set; }
        public short MapId15 { get; set; }
        public short MapId16 { get; set; }
        public short HolidayWorldState { get; set; }
        public short RequiredPlayerConditionId { get; set; }
        public sbyte InstanceType { get; set; }
        public sbyte GroupsAllowed { get; set; }
        public sbyte MaxGroupSize { get; set; }
        public sbyte MinLevel { get; set; }
        public sbyte MaxLevel { get; set; }
        public sbyte RatedPlayers { get; set; }
        public sbyte MinPlayers { get; set; }
        public sbyte MaxPlayers { get; set; }
        public sbyte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
