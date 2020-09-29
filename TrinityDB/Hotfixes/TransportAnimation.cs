using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class TransportAnimation
    {
        public uint Id { get; set; }
        public uint TimeIndex { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public byte SequenceId { get; set; }
        public int TransportId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
