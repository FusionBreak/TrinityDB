using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class CharacterHomebind
    {
        public ulong Guid { get; set; }
        public ushort MapId { get; set; }
        public ushort ZoneId { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
    }
}
