using System;
using System.Collections.Generic;

namespace TrinityDB.World
{
    public partial class Command
    {
        public string Name { get; set; }
        public ushort Permission { get; set; }
        public string Help { get; set; }
    }
}
