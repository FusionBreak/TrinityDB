using System;
using System.Collections.Generic;

namespace TrinityDB.Hotfixes
{
    public partial class TaxiPathNode
    {
        public float LocX { get; set; }
        public float LocY { get; set; }
        public float LocZ { get; set; }
        public ushort PathId { get; set; }
        public ushort ContinentId { get; set; }
        public byte NodeIndex { get; set; }
        public uint Id { get; set; }
        public byte Flags { get; set; }
        public uint Delay { get; set; }
        public ushort ArrivalEventId { get; set; }
        public ushort DepartureEventId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
