using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class AreaTrigger
    {
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Radius { get; set; }
        public float BoxLength { get; set; }
        public float BoxWidth { get; set; }
        public float BoxHeight { get; set; }
        public float BoxYaw { get; set; }
        public short ContinentId { get; set; }
        public short PhaseId { get; set; }
        public short PhaseGroupId { get; set; }
        public short ShapeId { get; set; }
        public short AreaTriggerActionSetId { get; set; }
        public sbyte PhaseUseFlags { get; set; }
        public sbyte ShapeType { get; set; }
        public sbyte Flags { get; set; }
        public uint Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
