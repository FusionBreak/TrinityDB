using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class Light
    {
        public uint Id { get; set; }
        public float GameCoordsX { get; set; }
        public float GameCoordsY { get; set; }
        public float GameCoordsZ { get; set; }
        public float GameFalloffStart { get; set; }
        public float GameFalloffEnd { get; set; }
        public short ContinentId { get; set; }
        public ushort LightParamsId1 { get; set; }
        public ushort LightParamsId2 { get; set; }
        public ushort LightParamsId3 { get; set; }
        public ushort LightParamsId4 { get; set; }
        public ushort LightParamsId5 { get; set; }
        public ushort LightParamsId6 { get; set; }
        public ushort LightParamsId7 { get; set; }
        public ushort LightParamsId8 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
