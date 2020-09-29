using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class GarrisonPlotFinalizeInfo
    {
        public uint GarrPlotInstanceId { get; set; }
        public uint HordeGameObjectId { get; set; }
        public float HordeX { get; set; }
        public float HordeY { get; set; }
        public float HordeZ { get; set; }
        public float HordeO { get; set; }
        public ushort HordeAnimKitId { get; set; }
        public uint AllianceGameObjectId { get; set; }
        public float AllianceX { get; set; }
        public float AllianceY { get; set; }
        public float AllianceZ { get; set; }
        public float AllianceO { get; set; }
        public ushort AllianceAnimKitId { get; set; }
    }
}
