using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class LinkedRespawn
    {
        public ulong Guid { get; set; }
        public ulong LinkedGuid { get; set; }
        public byte LinkType { get; set; }
    }
}
