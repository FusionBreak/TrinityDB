using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class WorldMapArea
    {
        public string AreaName { get; set; }
        public float LocLeft { get; set; }
        public float LocRight { get; set; }
        public float LocTop { get; set; }
        public float LocBottom { get; set; }
        public uint Flags { get; set; }
        public short MapId { get; set; }
        public ushort AreaId { get; set; }
        public short DisplayMapId { get; set; }
        public ushort DefaultDungeonFloor { get; set; }
        public ushort ParentWorldMapId { get; set; }
        public byte LevelRangeMin { get; set; }
        public byte LevelRangeMax { get; set; }
        public byte BountySetId { get; set; }
        public byte BountyDisplayLocation { get; set; }
        public uint Id { get; set; }
        public uint VisibilityPlayerConditionId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
