using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class TransportRotation
    {
        public uint Id { get; set; }
        public uint TimeIndex { get; set; }
        public float Rot1 { get; set; }
        public float Rot2 { get; set; }
        public float Rot3 { get; set; }
        public float Rot4 { get; set; }
        public int GameObjectsId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
