using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GmComplaint
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
        public ulong TargetCharacterGuid { get; set; }
        public ushort ComplaintType { get; set; }
        public int ReportLineIndex { get; set; }
        public long ClosedBy { get; set; }
        public ulong AssignedTo { get; set; }
        public string Comment { get; set; }
    }
}
