using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GameobjectRespawn
    {
        public ulong Guid { get; set; }
        public uint RespawnTime { get; set; }
        public ushort MapId { get; set; }
        public uint InstanceId { get; set; }
    }
}
