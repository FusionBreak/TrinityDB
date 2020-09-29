using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class CinematicCamera
    {
        public uint Id { get; set; }
        public uint SoundId { get; set; }
        public float OriginX { get; set; }
        public float OriginY { get; set; }
        public float OriginZ { get; set; }
        public float OriginFacing { get; set; }
        public uint FileDataId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
