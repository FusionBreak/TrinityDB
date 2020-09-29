using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GmSuggestion
    {
        public uint Id { get; set; }
        public ulong PlayerGuid { get; set; }
        public string Note { get; set; }
        public uint CreateTime { get; set; }
        public ushort MapId { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Facing { get; set; }
        public long ClosedBy { get; set; }
        public ulong AssignedTo { get; set; }
        public string Comment { get; set; }
    }
}
