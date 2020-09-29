using System;
using System.Collections.Generic;

namespace TrinityDB.Characters
{
    public partial class GroupInstance
    {
        public uint Guid { get; set; }
        public uint Instance { get; set; }
        public byte Permanent { get; set; }
    }
}
