using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class WorldMapOverlay
    {
        public string TextureName { get; set; }
        public uint Id { get; set; }
        public ushort TextureWidth { get; set; }
        public ushort TextureHeight { get; set; }
        public uint MapAreaId { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int HitRectTop { get; set; }
        public int HitRectLeft { get; set; }
        public int HitRectBottom { get; set; }
        public int HitRectRight { get; set; }
        public uint PlayerConditionId { get; set; }
        public uint Flags { get; set; }
        public uint AreaId1 { get; set; }
        public uint AreaId2 { get; set; }
        public uint AreaId3 { get; set; }
        public uint AreaId4 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
